﻿var dataTable;

$(document).ready(function () {
    cargarDatatable()
});


function cargarDatatable() {
    dataTable = $("#tblCiclos").DataTable({
        iDisplayLength: 25,
        bDestroy: true,
        bJQueryUI: true,

        bAutoWidth: true,
                 
        "ajax": {
           
            
            "url": "/admin/ciclos/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "30" },
            { "data": "anioAcademico", "width": "30" },
     
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center card border-primary justify-content-center">
                            <a href='/Admin/Ciclos/Edit/${data}' class='btn btn-success btn-sm text-white' style='cursor:pointer; width:70px;'>
                            <i class='fas fa-edit'></i> Editar
                            </a>
                            &nbsp;
                            <a onclick=Delete("/Admin/Ciclos/Delete/${data}") class='btn btn-danger btn-sm text-white' style='cursor:pointer; width:70px;'>
                            <i class='fas fa-trash-alt'></i> Borrar
                            </a>
                            `;
                }, "width": "1%"
            }
        ],
        "language": {

            
            "sProcessing": "Procesando...",

            "sLengthMenu": "Mostrar _MENU_ registros",

            "sZeroRecords": "No se encontraron resultados",

            "sEmptyTable": "Ningún dato disponible en esta tabla",

            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",

            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",

            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",

            "sInfoPostFix": "",

            "sSearch": "Buscar:",

            "sUrl": "",

            "sInfoThousands": ",",

            "sLoadingRecords": "Cargando...",

            "oPaginate": {

                "sFirst": "Primero",

                "sLast": "Último",

                "sNext": "Siguiente",

                "sPrevious": "Anterior"
            }
       
        },
        "width": "100%"
    })
}


function Delete(url) {
    swal({
        title: "¿Esta seguro de borrar?",
        text: "¡Este contenido no se puede recuperar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Si, ¡borrar!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}
