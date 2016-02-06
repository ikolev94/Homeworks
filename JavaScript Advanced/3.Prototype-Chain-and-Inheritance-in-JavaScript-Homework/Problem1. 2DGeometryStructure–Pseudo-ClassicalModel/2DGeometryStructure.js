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

        Shape.prototype.getDistanceBetweenPoints = function (aX, aY, bX, bY) {
            var deltaX = aX - bX;
            var deltaY = aY - bY;

            var distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        };

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

        Circle.prototype.draw = function (ctx) {
            var circleDraw = new Path2D();
            circleDraw.arc(this._centerX, this._centerY, this._radius, 0, 2 * Math.PI);
            ctx.fillStyle = this._color;
            ctx.fill(circleDraw);
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

        Rectangle.prototype.draw = function (ctx) {
            ctx.fillStyle = this._color;
            ctx.fillRect(this._topLeftX, this._topLeftY, this._width, this._height);
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
            this.setPoints(aX, aY, bX, bY, cX, cY);
        }

        Triangle.extends(Shape);

        Triangle.prototype.setPoints = function (aX, aY, bX, bY, cX, cY) {
            if (isValidTriangle(aX, aY, bX, bY, cX, cY)) {
                this._aX = aX;
                this._aY = aY;
                this._bX = bX;
                this._bY = bY;
                this._cX = cX;
                this._cY = cY;
            } else {
                console.error('Invalid coordinates (triangle)');
            }
        };

        function isValidTriangle(aX, aY, bX, bY, cX, cY) {
            var sideA = Shape.prototype.getDistanceBetweenPoints(aX, aY, bX, bY);
            var sideB = Shape.prototype.getDistanceBetweenPoints(bX, bY, cX, cY);
            var sideC = Shape.prototype.getDistanceBetweenPoints(aX, aY, cX, cY);

            if (sideA <= 0 || sideB <= 0 || sideC <= 0) {
                return false;
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) {
                return false;
            }

            return true;
        };

        Triangle.prototype.draw = function (ctx) {
            ctx.fillStyle = this._color;
            ctx.beginPath();
            ctx.moveTo(this._aX, this._aY);
            ctx.lineTo(this._bX, this._bY);
            ctx.lineTo(this._cX, this._cY);
            ctx.fill();
        }

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

        Line.prototype.draw = function (ctx) {
            ctx.strokeStyle = this._color;
            ctx.beginPath();
            ctx.moveTo(this._bX, this._bY);
            ctx.lineTo(this._aX, this._aY);
            ctx.stroke();
        };

        Line.prototype.toString = function () {
            return Shape.prototype.toString.call(this) +
                " A(" + this._aX + ", " + this._aY + ")," +
                " B(" + this._bX + ", " + this._bY + "), ";
        };

        return Line;
    }());

    var Segment = (function () {
        function Segment(aX, aY, bX, bY, color) {
            Line.call(this, aX, aY, bX, bY, color);
        }

        Segment.extends(Line);

        Segment.prototype.draw = function (ctx) {
            var distance = this.getDistanceBetweenPoints(this._aX, this._aY, this._bX, this._bY);
            console.log(distance);
            var rad = distance > 100 ? 10 : distance > 10 ? 5 : 0;
            ctx.strokeStyle = this._color;
            ctx.fillStyle = this._color;
            ctx.beginPath();
            ctx.arc(this._bX, this._bY, rad, 0, 2 * Math.PI);
            ctx.arc(this._aX, this._aY, rad, 0, 2 * Math.PI);
            ctx.fill();
            ctx.beginPath();
            ctx.moveTo(this._bX, this._bY);
            ctx.lineTo(this._aX, this._aY);
            ctx.stroke();
        };

        Segment.prototype.toString = function () {
            return Line.prototype.toString.call(this);

        };

        return Segment;
    }());

    return {
        Shape: Shape,
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    };
}());


var circle = new shapeModule.Circle(210, 300, 62, '#1D4F73');
console.log(circle.toString());

var rectangle = new shapeModule.Rectangle(100, 33, 341, 35, '#7F2F1A');
console.log(rectangle.toString());

var triangle = new shapeModule.Triangle(45, 150, 100, 175, 110, 105, '#abc112');
console.log(triangle.toString());

var line = new shapeModule.Line(501, 600, 600, 100, '#FF6A6A');
console.log(line.toString());

var segment = new shapeModule.Segment(170, 140, 440, 200, '#cccccc');
console.log(segment.toString());

console.log(segment instanceof shapeModule.Shape);

(function () {
    var canvas = document.getElementById('canvas');
    if (!canvas.getContext) {
        console.log('Canvas is ussuported!');
        return;
    }
    var ctx = canvas.getContext('2d');
    circle.draw(ctx);
    rectangle.draw(ctx);
    triangle.draw(ctx);
    line.draw(ctx);
    segment.draw(ctx);
}());

