import java.awt.Graphics;

public interface Animal {
	void moveAnimal(Graphics g);

	void drawAnimal(Graphics g);

	void setPos(int x, int y);

	void grow(int a);
}
