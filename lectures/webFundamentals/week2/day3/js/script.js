$(document).ready(function() {
    $('#hide01').click(function() {
        $('#img01').hide()
    })
    $('#show01').click(function() {
        $('#img01').show()
    })
    $('#toggle01').click(function() {
        $('#img02').animate( {
            width: 'toggle'
        })
    })
    $('#toggle02').hover(function() {
        $('#img03').animate( {
            width: 'toggle'
        })
        $('#toggle02').css({
            backgroundColor: 'red'
        })
    })
    $('.bubbleImg').click(function() {
        $(this).animate( {
            width: 'toggle'
        })
    })
    $('#hideNew').click(function() {
        $('#img01').animate( {
            width: 'toggle'
        })
    })
    $('#restore').click(function() {
        $('.bubbleImg').show()
        $('.img01').show()
    })
    $('#changeImg').click(function() {
        var i = $('#img01')
        console.log(i[0].alt)
        if(i[0].alt === "Fluffy") {
            $('#img01').replaceWith('<img src="./images/yankeeBoy.png" alt="Yankee Boy" id="img01" class="img01">' )
        } else {
            $('#img01').replaceWith('<img src="./images/fluffy.png" alt="Fluffy" id="img01" class="img01">' )
        }
    })
})