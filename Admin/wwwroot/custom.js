﻿$(document).ready(function () {
    $(".deleteitem").click(function (e) {
        e.preventDefault();
        let href = $(this).attr("href");
        $.confirm({
            title: 'Delete Data',
            content: 'Do you want delete data?',
            buttons: {
                'Bəli': {
                    btnClass: "btn-danger",
                    action: function () {
                        location.href = href;
                    }
                },
                'Xeyir': function () {

                }
            }
        });
    });
});