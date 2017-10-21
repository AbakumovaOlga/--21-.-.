public class WaterTap {
	private boolean open;

	public boolean GetOpen() {
		return open;

	}

	public void SetOpen(boolean o) {
		open = o;
	}

	public void Wash(Egg egg) {
		if (open) {
			egg.SetDirty(false);
		}
	}
}
