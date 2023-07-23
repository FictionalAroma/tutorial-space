using System.Drawing;

namespace RPGShopBeginner;

public class Dog
{
	private int legs;
	private bool tailStillOn;
	private bool boopableSnoot;
	private double BarkVolume;
	private Color furColour;

	public int ListenToHoomanFactor { get; } = 95;

	public void Sleep() { }
	public void Eat(int amount) { }
	public void Fetch(int target){ }

	public void Update() { }
}