function traverse(selector) {
    "use strict";
    var node = document.querySelector(selector);
    traverseNode(node, '');
    function traverseNode(node, spacing) {
        var i, child, len, nodeName, output;
        for (i = 0, len = node.childNodes.length; i < len; i += 1) {
            child = node.childNodes[i];
            if (child.nodeType === document.ELEMENT_NODE) {
                nodeName = (child.nodeName).toLowerCase();
                output = spacing + nodeName + ' : ';
                output += child.id ? 'id=\"' + child.id + '\" ' : '';
                output += child.className ? 'class=\"' + child.className + '\"' : '';
                console.log(output);
                traverseNode(child, spacing + '  ');
            }
        }
    }
}

traverse('.birds');
console.log();