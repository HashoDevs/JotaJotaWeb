


$(document).ready(function () {

    $('.contact-modal').on('shown.bs.modal', function () {
        console.log("Abierto");
        var elems = $('.ghost');
        elems.hide()
        
    });

    $('.contact-modal').on('hidden.bs.modal', function () {
        console.log("Cerrado");
        var elems = $('.ghost');
        elems.show()
    });

    $('.contact-modal').modal('show');

    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    });
});