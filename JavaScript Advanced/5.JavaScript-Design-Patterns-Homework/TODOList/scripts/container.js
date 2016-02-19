define(['section'], function (Section) {
    return (function () {
        "use strict";

        function Container(title) {
            this._title = title || 'Tuesday TODO List';
        }

        Container.prototype.createElement = function () {
            var container = document.createElement('div'),
                heading = document.createElement('h1'),
                sectionWrapper = document.createElement('main'),
                input = document.createElement('input'),
                button = document.createElement('button');

            container.id = 'wrapper';

            sectionWrapper.id = 'main';
            heading.innerText = this._title;
            button.innerText = 'New Section';
            button.addEventListener('click', new Section().addToDom);
            input.type = 'text';
            input.name = 'section-name';
            input.placeholder = 'Title...';
            container.appendChild(heading);
            container.appendChild(sectionWrapper);
            container.appendChild(input);
            container.appendChild(button);

            return container;
        };

        Container.prototype.addToDom = function () {
            var body = document.getElementsByTagName('body')[0];
            body.insertBefore(this.createElement(), body.childNodes[0]);
        };

        return Container;
    }());

});

