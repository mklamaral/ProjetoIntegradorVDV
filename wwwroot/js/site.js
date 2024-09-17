// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#link-usuario-vadevan').click(function () {
    $('.box-editar-info').hide(); // Esconde o box-editar-info
    $('.box-usuario-vadevan-menu').toggle(); // Mostra ou esconde o box-usuario-vadevan-menu
});

//$('.editar-info').click(function () {
//    $('.box-editar-info').toggle();
//    $('.box-usuario-vadevan-menu').toggle(); // Mostra ou esconde o box-usuario-vadevan-menu
//});

$(document).ready(function () {
    $("#CEP").blur(function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep != "") {
            var validacep = /^[0-9]{8}$/;
            if (validacep.test(cep)) {
                $("#Rua").val("...");
                $("#Bairro").val("...");
                $("#Cidade").val("...");
                $("#Estado").val("...");
                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                    if (!("erro" in dados)) {
                        $("#Rua").val(dados.logradouro);
                        $("#Bairro").val(dados.bairro);
                        $("#Cidade").val(dados.localidade);
                        $("#Estado").val(dados.uf);
                    } else {
                        alert("CEP não encontrado.");
                    }
                });
            } else {
                alert("Formato de CEP inválido.");
            }
        }
    });
});
$(document).ready(function () {
    $("#CEPAdc").blur(function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep != "") {
            var validacep = /^[0-9]{8}$/;
            if (validacep.test(cep)) {
                $("#RuaAdc").val("...");
                $("#BairroAdc").val("...");
                $("#CidadeAdc").val("...");
                $("#EstadoAdc").val("...");
                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {
                    if (!("erro" in dados)) {
                        $("#RuaAdc").val(dados.logradouro);
                        $("#BairroAdc").val(dados.bairro);
                        $("#CidadeAdc").val(dados.localidade);
                        $("#EstadoAdc").val(dados.uf);
                    } else {
                        alert("CEP não encontrado.");
                    }
                });
            } else {
                alert("Formato de CEP inválido.");
            }
        }
    });
});
$(document).ready(function () {
    //Carrega a pagina com a div Deficiencia oculta
    var deficienciaDiv = $('#DeficienciaDiv');
    deficienciaDiv.addClass('d-none').hide();
    //Faz uma validação no campo "PossuiDeficiencia" para ocultar ou mostrar a div Deficiencia
    $('#PossuiDeficiencia').change(function () {
        var deficienciaDiv = $('#DeficienciaDiv');
        if ($(this).val() === 'Sim') {
            deficienciaDiv.removeClass('d-none').show();
        } else {
            deficienciaDiv.addClass('d-none').hide();
        }
    });
});
$(document).ready(function () {
    var formResposavelAdc = $('#FormResposavelAdc');
    formResposavelAdc.addClass('d-none').hide();
    $('#BtnResponsavelAdc').click(function (event) {
        event.preventDefault();
        formResposavelAdc.removeClass('d-none').addClass('form-posicionado').show();
    });
});


$(document).ready(function () {
    $('#verPrecos').click(function (event) {
        event.preventDefault(); // Previne o carregamento ao clicar no botão
        console.log('Botão clicado');

        var origem = $('#origem').val();
        var destino = $('#destino').val();
        console.log('Origem:', origem, 'Destino:', destino);

        var service = new google.maps.DistanceMatrixService();
        service.getDistanceMatrix({
            origins: [origem],
            destinations: [destino],
            travelMode: 'DRIVING',
        }, function (response, status) {
            console.log('Status da API:', status);
            if (status == 'OK') {
                console.log('Resposta da API:', response);
                var origins = response.originAddresses;
                var destinations = response.destinationAddresses;

                for (var i = 0; i < origins.length; i++) {
                    var results = response.rows[i].elements;
                    for (var j = 0; j < results.length; j++) {
                        var element = results[j];
                        var distanceText = element.distance.text;
                        var distanceValue = element.distance.value; // distancia em metros
                        var distanceKm = distanceValue / 1000; // converter para km
                        var adjustedDistance;

                        if (distanceKm <= 2) {
                            adjustedDistance = distanceKm * 7; // preço cheio nos primeiros 2km
                        } else {
                            adjustedDistance = (2 * 7) + ((distanceKm - 2) * 2); // preço cheio nos primeiros 2km, depois 2 reais por km
                        }

                        $('#resultado').text('O preço aproximadamente é de: ' + 'R$' + adjustedDistance.toFixed(2));
                        console.log('O preço aproximadamente é de: ' + 'R$', adjustedDistance.toFixed(2));
                    }
                }
            } else {
                console.error('Erro na API:', status);
            }
        });
    });
});

window.setTimeout(function () {
    $(".alert").fadeTo(500, 0).slideUp(500, function () {
        $(this).remove();
    });
}, 3000)




