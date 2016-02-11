var todoList = todoList || {};

todoList.Section = (function (list) {
    "use strict";

    function Section(title) {
        this._title = title;
    }

    Section.prototype.createElement = function () {
        var section = document.createElement('section'),
            input = document.createElement('input'),
            button = document.createElement('button'),
            h3 = document.createElement('h3'),
            ul = document.createElement('ul');
        input.type = 'text';
        input.placeholder = 'Add Item...';
        input.name = 'item-name';
        button.innerText = '+';
        button.addEventListener('click', new list.Item().addToDom);
        ul.className = 'container';
        h3.innerText = this._title;
        section.appendChild(h3);
        section.appendChild(ul);
        section.appendChild(input);
        section.appendChild(button);

        return section;
    };

    Section.prototype.addToDom = function (event) {
        var parent = event.target.parentNode,
            title = parent.querySelector('input[name=section-name]').value,
            wrapper = document.querySelector('#main'),
            section = new Section(title);

        wrapper.appendChild(section.createElement());
    };

    return Section;
}(todoList));