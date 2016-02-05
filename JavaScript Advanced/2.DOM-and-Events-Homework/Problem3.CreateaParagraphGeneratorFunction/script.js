function createParagraph(id, text) {
    var p = document.createElement('p');
    p.innerText = text;
    var parent = document.getElementById(id);
    parent.appendChild(p);
}

createParagraph('wrapper','Some text');