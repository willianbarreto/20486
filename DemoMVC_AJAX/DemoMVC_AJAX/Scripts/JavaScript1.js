function MensagemExterna() {
    alert('Está é uma mensagem do JavaScript Externo');
}

$('#btn').click(function () {
    var texto = $('#txt2').val();
    alert(texto);
});