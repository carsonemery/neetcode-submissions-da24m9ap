public class SquareHole {
    private double sideLength;

    public SquareHole(double sideLength) {
        this.sideLength = sideLength;
    }

    public bool canFit(Square square) {
        return this.sideLength >= square.getSideLength();
    }
}

public class Square {
    private double sideLength;

    public Square() {}

    public Square(double sideLength) {
        this.sideLength = sideLength;
    }

    public virtual double getSideLength() {
        return this.sideLength;
    }
}

public class Circle {
    private double radius;

    public Circle(double radius) {
        this.radius = radius;
    }

    public double getRadius() {
        return this.radius;
    }
}

public class CircleToSquareAdapter : Square {
    // Create a new private sideLength variable for this circle to square adapter class
    private double sideLength;

    public CircleToSquareAdapter(Circle circle) {
        // construct/assign this "squares" sideLength to double the radius of the circle object
        this.sideLength = circle.getRadius() * 2;
    }

    public override double getSideLength() {
      // return this sideLength
      return this.sideLength;
    }
}
