$(document).ready(function () {

    $('img').not(':first').hide();

    setInterval(function () {
        $('img:first')
        .fadeOut(1250)
            .next()
            .fadeIn(1250)
            .end()
            .appendTo('#images');
    }, 2000);

    $('#next').on('click', function () {
        $('#images').find('> img').filter(function () {
            return $(this).css('display') !== 'none';
        }).first().fadeOut(50).next().fadeIn(50);
    });

    $('#previous').on('click', function () {
        $('#images').find('>img').filter(function () {
            return $(this).css('display') !== 'none';
        }).first().fadeOut(500).prev().fadeIn(500);
    });
});