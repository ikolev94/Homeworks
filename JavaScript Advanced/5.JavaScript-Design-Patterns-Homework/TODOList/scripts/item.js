define(['notie'], function () {
    return (function () {
        "use strict";
        var idNumber = 0; // Create unique id for label (if two items have same content)

        function Item(content, status) {
            setContent.call(this, content);
            this._status = status;
            idNumber++;
        }

        function setContent(content) {
            if (content === '') {
                notie.alert(3, 'Item content cannot be empty', 1.5);
                throw new Error('Item content cannot be empty');
            }
            this._content = content;
        }

        Item.prototype.createElement = function () {
            var li = document.createElement('li'),
                checkbox = document.createElement('input'),
                label = document.createElement('label');
            checkbox.id = 'item' + idNumber;
            checkbox.type = "checkbox";
            label.htmlFor = 'item' + idNumber;
            label.appendChild(document.createTextNode(this._content));
            li.appendChild(checkbox);
            li.appendChild(label);

            return li;
        };

        Item.prototype.addToDom = function (e) {
            var parent = e.target.parentNode,
                title = parent.querySelector('input[name=item-name]').value,
                container = parent.querySelector('.container'),
                item = new Item(title);
            parent.querySelector('input[name=item-name]').value = '';
            container.appendChild(item.createElement());
        };

        return Item;
    }());
});

