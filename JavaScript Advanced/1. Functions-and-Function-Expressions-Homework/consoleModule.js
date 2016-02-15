var specialConsole = (function () {
    "use strict";
    function replaceArgs(text, params) {
        var pattern, match, placeholder, digit, replacement;
        pattern = /\{(\d+)\}/g;
        match = pattern.exec(text);

        while (match) {
            placeholder = match[0];
            digit = Number(match[1]);
            replacement = params[digit];

            if (replacement === undefined) {
                throw new Error('invalid arguments');
            }
            text = text.replace(placeholder, replacement.toString());
            match = pattern.exec(text);
        }

        return text;
    }

    function writeLine() {
        var text = arguments[0];
        Array.prototype.shift.apply(arguments);

        text = replaceArgs(text, arguments);

        console.log(text);
    }

    function writeError() {
        var text = arguments[0];
        Array.prototype.shift.apply(arguments);

        text = replaceArgs(text, arguments);

        console.error(text);

    }

    function writeWarning() {
        var text = arguments[0];
        Array.prototype.shift.apply(arguments);

        text = replaceArgs(text, arguments);

        console.warn(text);
    }

    function writeInfo() {
        var text = arguments[0];
        Array.prototype.shift.apply(arguments);

        text = replaceArgs(text, arguments);

        console.info(text);
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning,
        writeInfo: writeInfo
    };
}());


specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeLine("Object: {0}", {
    name: "Gosho", toString: function () {
        "use strict";
        return this.name;
    }
});
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");
specialConsole.writeInfo("Info: {0}", "Hi there! Here is some info for you.");
specialConsole.writeError("Error object: {0}", {
    msg: "An error happened", toString: function () {
        "use strict";
        return this.msg;
    }
});