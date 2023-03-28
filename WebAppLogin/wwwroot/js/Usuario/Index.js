ns('WebAppLogin.Usuario.Index');

try {

    $(document).ready(function () {
        'use strict';
        debugger;
        /* WebAppLogin.Usuario.Index.Page = new WebAppLogin.Usuario.Index.Controller();*/
        //WebAppLogin.Usuario.Index.Page.Ini();

        $('#btnLogin').on('click', function () {
            debugger;
            inicioSesion();
        });

    });

    function inicioSesion() {

        var usuarioLocal = $('#txtUsuario').val();
        var passwordLocal = $('#txtPassword').val();

        var oData = {
            User: usuarioLocal,
            Password: passwordLocal
        };

        $.ajax({
            url: '/Usuario/ValidateLogin',
            data: oData,
            method: 'GET',
            dataType: 'json',
            success: function (response) {
                var objData = jQuery.parseJSON(response);
               
            },
            failure: function (msg) {
                console.log("entro a la funcion failure");
                console.log(msg);
            },
            error: function () {
                console.log("ERROR: No se ha podido obtener la información");
            },
        });
    }


} catch (ex) {
    alert(ex.message);
}