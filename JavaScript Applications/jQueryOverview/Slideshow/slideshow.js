(function () {
    "use strict";
    var index = 0,
        container = $('#images-container'),
        images = $('img'),
        currentImage;

    function previousSlide() {
        images.hide();
        currentImage = $(images[index]);
        index--;
        if (index < 0) index = 4;
        currentImage.fadeIn(1000);
    }

    function nextSlide() {
        images.hide();
        currentImage = $(images[index]);
        index++;
        if (index > 4) index = 0;
        currentImage.fadeIn(1000);
    }

    $(document).ready(function () {
        $('#left').on('click', previousSlide);
        $('#right').on('click', nextSlide);
        nextSlide();
        setInterval(function () {
            $('#right').trigger('click');
        }, 3000);
    });
}());