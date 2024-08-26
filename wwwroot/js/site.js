// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


document.addEventListener('DOMContentLoaded', function () {
    let table = new DataTable('#table-clientes', {
        language: {
            url: "//cdn.datatables.net/plug-ins/1.13.4/i18n/pt-BR.json"
        }
    });
});

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});