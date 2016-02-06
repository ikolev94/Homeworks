"use strict";

if (!Object.create) {
    Object.create = function (proto) {
        function F() {
        }

        F.prototype = proto;
        return new F();
    };
}

Object.prototype.extends = function (parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

function isNumeric(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

var shapeModule = (function () {

    var Shape = (function () {
        function Shape(color) {
            if (this.constructor === Shape) {
                throw new Error('Cannot create instance of Shape');
            }
            this._color = color;
        }

        Shape.prototype.toString = function () {
            return this.constructor.name + ': Color: ' + this._color;
        };

        return Shape;
    }());

    var Circle = (function () {
        function Circle(centerX, centerY, radius, color) {
            Shape.call(this, color);
            this._centerX = centerX;
            this._centerY = centerY;
            this.setRadius(radius)
        }

        Circle.extends(Shape);

        Circle.prototype.setRadius = function (radius) {
            if (!isNumeric(radius)) {
                throw new Error('Invalid radius (circle)')
            }
            this._radius = Number(radius);
        };

        Circle.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                ' center X = ' + this._centerX + ' center Y = ' +
                this._centerY + ' radius = ' + this._radius;
        };

        return Circle;
    }());

    var Rectangle = (function () {
        function Rectangle(topLeftX, topLeftY, width, height, color) {
            Shape.call(this, color);
            this._topLeftX = topLeftX;
            this._topLeftY = topLeftY;
            this.setWidth(width);
            this.setHeight(height);
        }

        Rectangle.extends(Shape);


        Rectangle.prototype.setWidth = function (width) {
            if (!isNumeric(width)) {
                throw new Error('invalid width (rectangle)')
            }
            this._width = Number(width);
        };

        Rectangle.prototype.setHeight = function (height) {
            if (!isNumeric(height)) {
                throw new Error('invalid width (rectangle)')
            }
            this._height = Number(height);
        };

        Rectangle.prototype.toString = function () {

            return Shape.prototype.toString.call(this) +
                ' top left X = ' + this._topLeftX + ' top left Y = ' +
                this._topLeftY + ' width = ' + this._width + ' height = ' + this._height;
        };

        return Rectangle;
    }());

    var Triangle = (function () {
        function Triangle(aX, aY, bX, bY, cX, cY, color) {
            Shape.call(this, color);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
            this._cX = cX;
            this._cY = cY;
        }

        Triangle.extends(Shape);

        Triangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + " A(" + this._aX + ", " + this._aY + "),"
                + " B(" + this._bX + ", " + this._bY + "),"
                + " C(" + this._cX + ", " + this._cY + ")";
        };

        return Triangle;
    }());

    var Line = (function () {
        function Line(aX, aY, bX, bY, color) {
            Shape.call(this, color);
            this._aX = aX;
            this._aY = aY;
            this._bX = bX;
            this._bY = bY;
        }

        Line.extends(Shape);

        Line.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                " A(" + this._aX + ", " + this._aY + ")," +
                " B(" + this._bX + ", " + this._bY + "), ";
        };

        return Line;
    }());

    var Segment = (function () {
        function Segment(aX,aY,bX,bY,color) {
            Line.call(this,aX,aY,bX,bY,color);
        }

        Segment.extends(Line);

        Segment.prototype.toString = function() {
            return Line.prototype.toString.call(this);

        };

        return Segment;
    }());

    return {
        Shape:Shape,
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line:Line,
        Segment:Segment
    };
}());


var circle = new shapeModule.Circle(0, 0, 12, '#ffffff');
console.log(circle.toString());

var rectangle = new shapeModule.Rectangle(1, 3, 3, 5, '#aaaa');
console.log(rectangle.toString());

var triangle = new shapeModule.Triangle(2, 2, 3, 3, 4, 4, '#abc112');
console.log(triangle.toString());

var line = new shapeModule.Line(0,0,1,22,'#ffaaff');
console.log(line.toString());

var segment = new shapeModule.Segment(10,3,1,2,'#cccccc');
console.log(segment.toString());

console.log(segment instanceof shapeModule.Shape);
