﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#table_id').DataTable({
        "language": {
            "info": "Exibindo _START_ até _END_ de _TOTAL_ registros.",
        }
    });

});