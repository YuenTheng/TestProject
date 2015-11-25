#include <stdio.h>

public class Characters
{
public :
	
	int health;
	int	speed;
	
	void setCurhealth(int a)
	{
		
		health = a;
		
	}
	
	void setCurspeed(int a)
	{
		
		speed = a;
		
	}

private:	
	
	void getCurhealth()
	{
		
		return health;
		
	}
	
	void getCurspeed(int a)
	{
		
		return speed;
	}
	
}