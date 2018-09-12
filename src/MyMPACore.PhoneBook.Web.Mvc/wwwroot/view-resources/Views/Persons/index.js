﻿(function() {

    $(function() {
        var _personService = abp.services.app.person;
        var _$modal = $("#PersonCreateModal");
        var _$form = _$modal.find('form');
        //begin 添加联系人功能
        _$form.find('button[type="submit"]').click(function(e) {
            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }
            var personEditDto = _$form.serializeFormToObject(); //序列化表单成对象
            abp.ui.setBusy(_$modal);
            //约定大于配置
            _personService.createOrUpdatePerson({ personEditDto }).done(function() {
                _$modal.modal('hide');
                location.reload();
            }).always(function() {
                abp.ui.clearBusy(_$modal);
            });
        });
        //end add
        //begin 刷新
        $("#RefreshButton").click(function() {
            refreshPersonList();
        });
        function refreshPersonList() {
            location.reload();
        }
        //end 刷新
        //begin 删除联系人信息
        $(".delete-person").click(function() {
            var personId = $(this).attr("data-person-id");
            var personName = $(this).attr("data-person-name");
            deletePerson(personId,personName);
        });
        function deletePerson(id, name) {
            abp.message.confirm("是否确认删除姓名为：" + name + "的联系人？",
                function(isConfirmed) {
                    if (isConfirmed) {
                        _personService.deletePerson({ id }).done(function() {
                            refreshPersonList();
                        });
                    }
                });
        }
        //end 删除
        //begin 编辑联系人信息
        $(".edit-person").click(function (e) {
            e.preventDefault();
            var personId = $(this).attr("data-person-id");
            _personService.getPersonForEdit({id:personId}).done(function(data) {
                $("input[name=Id]").val(data.person.id);
                $("input[name=Name]").val(data.person.name).parent().addClass('focused');
                $("input[name=EmailAddress]").val(data.person.emailAddress).parent().addClass('focused');
                $("input[name=Address]").val(data.person.address).parent().addClass('focused');
            });
        });
        //end 编辑
        //清空表单
        $("#PersonCreateModal").on("hide.bs.modal",
            function () {
                _$form[0].reset();
            });
    });
})();