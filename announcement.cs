void Main()
{
	var welcomeMsg = "Hang Tight folks.We have an announcement to make.... \n";
	Util.WithStyle(welcomeMsg, "font-family:consolas;color:dodgerblue; font-size:200%").Dump();
	var pb = new Util.ProgressBar("Its Brewing.................\n");
	Util.WithStyle(pb, "font-family:consolas;color:dodgerblue; font-size:200%").Dump();
	for (int index = 0; index <= 100; index++)
	{
		pb.Percent = index;
		Thread.Sleep(50);
	}
	var msg = "Some of you have guessed and others had no clue. February 2019, Our Baby Boy Is Due.";
	Util.WithStyle(msg, "font-family:consolas;color:dodgerblue; font-size:200%").Dump();
	var baby = makeBaby();
	var newLine = "\n".Dump();
	baby.Dump();
	var momndad = "\n Mom & Dad: Sowmya Acha & Raj Ankathi";
	Util.WithStyle(momndad, "font-family:consolas;color:dodgerblue; font-size:200%").Dump();
	//Util.RawHtml(new XElement("p", new XAttribute("style", "color:violet; font-size:150%"),"Raj" + " " + "Ankathi")).Dump();
}

static Object makeBaby()
{
	var me =Util.Image("https://xn--i-7iq.ws/emoji-image/%F0%9F%91%B6%F0%9F%8F%BB.png?format=emojione&ar=16x9");
	//Util.Image("https://xn--i-7iq.ws/emoji-image/%F0%9F%91%A8%F0%9F%8F%BB%F0%9F%91%A9%F0%9F%8F%BB%F0%9F%91%B6%F0%9F%8F%BB.png?format=emojione&ar=16x9");	
	return me;

	//	var pb1 = new Util.ProgressBar("Tada I am a BOY!! Arriving in Feb 2019");
	//	pb1.Percent = 100;
	//	pb1.Dump();
}