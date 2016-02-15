var HTMLGenerator = (function () {

    "use strict";
    function createParagraph(id, text) {
        var element, p;
        element = document.getElementById(id);
        p = document.createElement('p');
        p.innerText = text;
        element.appendChild(p);
    }

    function createDiv(id, divClass) {
        var element, div;
        element = document.getElementById(id);
        div = document.createElement('div');
        div.className = divClass;
        element.appendChild(div);
    }

    function createLink(id, text, url) {
        var element, a;
        element = document.getElementById(id);
        a = document.createElement('a');
        a.href = url;
        a.innerText = text;
        element.appendChild(a);
    }

    return {
        createParagraph: createParagraph,
        createDiv: createDiv,
        createLink: createLink
    };
}());

HTMLGenerator.createParagraph('wrapper', 'Soft Uni');
HTMLGenerator.createDiv('wrapper', 'section');
HTMLGenerator.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');