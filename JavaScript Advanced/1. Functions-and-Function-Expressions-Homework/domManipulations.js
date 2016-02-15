var domModule = (function () {

    "use strict";
    function selectorParser(selector) {
        return document.querySelector(selector);
    }

    function appendChild(parent, child) {
        if (typeof parent === "string") {
            parent = selectorParser(parent);
        }

        if (!parent) {
            throw new ReferenceError('Parent is invalid.');
        }

        if (typeof child === "string") {
            child = selectorParser(child);
        }
        if (!child) {
            throw new ReferenceError('Child element is invalid.');
        }

        parent.appendChild(child);
    }

    function removeChild(parent, child) {
        if (typeof parent === "string") {
            parent = selectorParser(parent);
        }

        if (!parent) {
            throw new ReferenceError('Parent is invalid.');
        }

        if (typeof child === "string") {
            child = selectorParser(child);
        }
        if (!child) {
            throw new ReferenceError('Child element is invalid.');
        }

        parent.removeChild(child);
    }

    function addHandler(elements, eventType, eventHandler) {
        var i;
        if (!(elements instanceof Element) && !Array.isArray(elements)) {
            elements = retrieveElements(elements);
        }

        if (!elements) {
            throw new ReferenceError('Invalid element(s)');
        }

        for (i = 0; i < elements.length; i++) {
            if (elements[i] instanceof HTMLElement) {
                elements[i].addEventListener(eventType, eventHandler);
            }

        }
    }

    function retrieveElements(selector) {
        return document.querySelectorAll(selector);
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };
}());

var liElement = document.createElement('li');

domModule.appendChild('.birds-list', liElement);
domModule.removeChild('ul.birds-list', 'li:first-child');
domModule.addHandler('li.bird', 'click', function () {
    alert('Hallo I\'m a bird!');
});
var elements = domModule.retrieveElements('.birds');