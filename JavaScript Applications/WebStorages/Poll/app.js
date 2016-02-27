(function () {
    var id = 0,
        currentId,
        clockId,
        fiveMinutes;

    function createQuestion(questionArgs) {
        currentId = id++;
        clockId = 'clock-' + currentId;
        $('<form>').attr('id', currentId)
            .css({'margin': '0 auto', 'width': '500px'})
            .appendTo(document.body);
        $('#' + currentId).append(
            $('<h3>').text(questionArgs[0]),
            $('<button>').text(questionArgs[1]),
            $('<button>').text(questionArgs[2]),
            $('<button>').text(questionArgs[3]),
            $('<button>').text(questionArgs[4]),
            $('<div style="float: right">').attr('id', clockId));
        fiveMinutes = new Date(Date.parse(new Date()) + 5 * 60 * 1000);
        initializeClock(clockId, fiveMinutes);
    }

    function getTimeRemaining(deadline) {
        var t = Date.parse(deadline) - Date.parse(new Date());
        var seconds = Math.floor((t / 1000) % 60);
        var minutes = Math.floor((t / 1000 / 60) % 60);
        var hours = Math.floor((t / (1000 * 60 * 60)) % 24);
        var days = Math.floor(t / (1000 * 60 * 60 * 24));
        return {
            'total': t,
            'days': days,
            'hours': hours,
            'minutes': minutes,
            'seconds': seconds
        };
    }

    function initializeClock(id, endtime) {
        var clock = document.getElementById(id);
        var timeinterval = setInterval(function () {
            var t = getTimeRemaining(endtime);
            clock.innerHTML = 'Time (' + t.minutes + ':' + t.seconds + ')';
            if (t.total <= 0) {
                clearInterval(timeinterval);
            }
        }, 1000);
    }

    createQuestion(['What\'s your name', 'Peter', 'Al', 'Jon', 'George']);
    createQuestion(['What\'s your name', 'Peter', 'Al', 'Jon', 'George']);
}());