Object.prototype.extend = function (properties) {
    function f() {
    }

    f.prototype = Object.create(this);
    for (var prop in properties) {
        f.prototype[prop] = properties[prop];
    }
    f.prototype._super = this;
    return new f();
};

var shapeModule = (function () {
    var shape = {
        init: function init(color) {
            this._color = color;
        },
        toString: function () {
            return ' color = ' + this._color;
        }
    };

    var circle = shape.extend({
        init: function init(centerX, centerY, radius, color) {
            this._super.init(color);
            this._centerX = centerX;
            this._centerY = centerY;
            this._radius = radius;
        },
        toString: function () {
            return 'Circle: O(' + this._centerX + ', ' + this._centerY + ') radius = '
                + this._radius + this._super.toString();
        }
    });

    var rectangle = shape.extend({
        init: function init(topLeftX, topLeftY, width, height, color) {
            this._super.init(color);
            this._topLeftX = topLeftX;
            this._topleftY = topLeftY;
            this._width = width;
            this._height = height;
        },
        toString: function () {
            return "Rectangle: Top-Left(" + this._topLeftX + ", "
                + this._topleftY + "), Width: " + this._width + ", Height: "
                + this._height + this._super.toString();
        }
    });

    var triangle = shape.extend({
        init: function init(aX, aY, bX, bY, cX, cY, color) {
            this._super.init(color);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._cX = cX;
            this._cY = cY;
        },
        toString: function () {
            return "Triangle: A(" + this._aX + ", " + this._aY + "), " +
                "B(" + this._bX + ", " + this._bY + "), " +
                "C(" + this._cX + ", " + this._cY + "),"
                + this._super.toString();
        }
    });

    var line = shape.extend({
        init: function (aX, aY, bX, bY, color) {
            this._super.init(color);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
        },
        toString: function () {
            return "Line: A(" + this._aX + ", " + this._aY + ")," +
                " B(" + this._bX + ", " + this._bY + "), " +
                "" + this._super.toString();
        }
    });

    var segment = line.extend({
        init: function (aX, aY, bX, bY, color) {
            this._super.init(aX, aY, bX, bY, color);
        },
        toString: function () {
            return "Segment: A(" + this._aX + ", " + this._aY + "), " +
                "B(" + this._bX + ", " + this._bY + "),"
                + this._super._super.toString();
        }
    });

    return {
        circle: circle,
        rectangle: rectangle,
        triangle: triangle,
        line: line,
        segment: segment
    };
}());

var circle = Object.create(shapeModule.circle);
circle.init(3, 5, 111, "#121212");
console.log(circle.toString());

var rectangle = Object.create(shapeModule.rectangle);
rectangle.init(3, 16, 5, 33, "#ffffff");
console.log(rectangle.toString());

var triangle = Object.create(shapeModule.triangle);
triangle.init(1, 2, 1, 2, 53, 1, "#aaabbb");
console.log(triangle.toString());

var line = Object.create(shapeModule.line);
line.init(99, 9, 9, 9, "#bbb222");
console.log(line.toString());

var segment = Object.create(shapeModule.segment);
segment.init(1, 11, 111, 111, "#000000");
console.log(segment.toString());