function createParagraph(id, text) {
    "use strict";
    var p, parent;
    p = document.createElement('p');
    p.innerText = text;
    parent = document.getElementById(id);
    parent.appendChild(p);
}

createParagraph('wrapper', 'Some text');