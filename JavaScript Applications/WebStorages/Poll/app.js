(function () {
    "use strict";
    var id = 0,
        currentId,
        questionId,
        firstAnswerId,
        secondAnswerId,
        thirdAnswerId,
        fourthAnswerId,
        endTime,
        clock,
        timeInterval,
        total,
        minutes,
        seconds,
        time,
        idOfCheckedInput,
        FIVE_MINUTES = 5,
        correctAnswers = {
            'question-0': 'third-answer-0',
            'question-1': 'second-answer-1',
            'question-2': 'third-answer-2',
            'question-3': 'third-answer-3'
        };

    function createQuestion(questionArgs) {
        currentId = id++;
        questionId = 'question-' + currentId;
        firstAnswerId = 'first-answer-' + currentId;
        secondAnswerId = 'second-answer-' + currentId;
        thirdAnswerId = 'third-answer-' + currentId;
        fourthAnswerId = 'forth-answer-' + currentId;

        return $('<fieldset>').css({'margin': '0 auto', 'width': '600px', 'text-align': 'center'})
            .append(
                $('<h3>').text(questionArgs[0]),
                $('<input>').attr({
                    'type': 'radio',
                    'value': questionArgs[1],
                    'id': firstAnswerId,
                    'name': questionId
                }),
                $('<label>').text(questionArgs[1]).attr('for', firstAnswerId),
                $('<input>').attr({
                    'type': 'radio',
                    'value': questionArgs[2],
                    'id': secondAnswerId,
                    'name': questionId
                }),
                $('<label>').text(questionArgs[2]).attr('for', secondAnswerId),
                $('<input>').attr({
                    'type': 'radio',
                    'value': questionArgs[3],
                    'id': thirdAnswerId,
                    'name': questionId
                }),
                $('<label>').text(questionArgs[3]).attr('for', thirdAnswerId),
                $('<input>').attr({
                    'type': 'radio',
                    'value': questionArgs[4],
                    'id': fourthAnswerId,
                    'name': questionId
                }),
                $('<label>').text(questionArgs[4]).attr('for', fourthAnswerId),
                $('<hr>'));
    }

    function getTimeRemaining(deadline) {
        total = Date.parse(deadline) - Date.parse(new Date());
        seconds = Math.floor((total / 1000) % 60);
        minutes = Math.floor((total / 1000 / 60) % 60);
        return {
            'total': total,
            'minutes': minutes,
            'seconds': seconds
        };
    }

    function initializeClock(id, minutes) {
        endTime = new Date(Date.parse(new Date()) + minutes * 60 * 1000);
        clock = document.getElementById(id);
        timeInterval = setInterval(function () {
            time = getTimeRemaining(endTime);
            clock.innerHTML = 'Time (' + time.minutes + ':' + time.seconds + ')';
            if (time.total <= 0) {
                clearInterval(timeInterval);
            }
        }, 1000);
    }

    $('<form style="text-align: center">')
        .append(
            $('<div id="clock">'),
            createQuestion(['#FFFFFF = ?', 'Red', 'Yellow', 'White', 'Green']),
            createQuestion(['10 + 10x0 + 10 = ?', '0', '20', '30', '100']),
            createQuestion(['There are 12 pens on the table, you took 3, how many do you have?', '2', '12', '3', 'PI']),
            createQuestion(['Finish the sentence, Gym is to Healthy as Book is to ?', 'Smart', 'Intelligent', 'Knowledgeable', 'Good']),
            $('<button type="button">').text('Submit').on('click', function () {
                clearInterval(timeInterval);
                $("input:not(:checked)").hide().next().hide();
                $('input:checked').each(function () {
                    if (correctAnswers[this.name] === this.id) {
                        this.parentNode.style.background = 'green';
                    } else {
                        $('#' + correctAnswers[this.name]).show().next().show();
                        this.parentNode.style.background = 'red';
                    }
                });
            }))
        .appendTo(document.body);

    initializeClock('clock', FIVE_MINUTES);

    if (localStorage.length) {
        Object.keys(localStorage).forEach(function (key) {
            idOfCheckedInput = '#' + localStorage[key];
            $(idOfCheckedInput).attr('checked', 'checked');
        });
    }

    $(window).on('beforeunload', function () {
        $('input:checked').each(function () {
            localStorage[this.name] = this.id;
        });
    })

}());