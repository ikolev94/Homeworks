var todoList = todoList || {};

todoList.Section = (function (list) {
    "use strict";

    function Section(title) {
        setTitle.call(this, title);
    }

    function setTitle(title) {
        if (title === '') {
            notie.alert(3, 'Section title cannot be empty', 1.5);
            throw new Error('Section title cannot be empty');
        }
        this._title = title;
    }

    Section.prototype.createElement = function () {
        var section = document.createElement('section'),
            input = document.createElement('input'),
            button = document.createElement('button'),
            h3 = document.createElement('h3'),
            ul = document.createElement('ul'),
            div = document.createElement('div');
        input.type = 'text';
        input.placeholder = 'Add Item...';
        input.name = 'item-name';
        button.innerText = '+';
        button.addEventListener('click', new list.Item().addToDom);
        ul.className = 'container';
        ul.addEventListener('click', function (e) {
            console.log(e);
        });
        h3.innerText = this._title;
        div.className = 'section-head-ul';
        div.appendChild(h3);
        div.appendChild(ul);
        section.appendChild(div);
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