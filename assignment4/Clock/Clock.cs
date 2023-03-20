namespace clock{
    public class Clock
    {
        DateTime alarmTime = DateTime.Now;

        public delegate void AlarmHandler(object sender, DateTime args);
        public delegate void TickHanlder(object sender, DateTime args);

        public event AlarmHandler onAlarm;
        public event TickHanlder onTick;

        public Clock()
        {
            onAlarm += Alarm;
            onTick += Tick;
        }

        public void Alarm(object sender, DateTime time)
        {
            Console.WriteLine("叮铃铃！您设定的时间" + time + "到啦！");
        }

        public void Tick(object sender, DateTime time)
        {
            Console.WriteLine("现在是" + time);
        }

        public void Start()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                onTick(this, now);
                if (now.ToString() == alarmTime.ToString())
                {
                    onAlarm(this, alarmTime);
                }
                Thread.Sleep(1000);
            }
        }

        public void SetAlarmTime(DateTime atime)
        {
            Console.WriteLine("闹钟设定为："+ atime);
            alarmTime = atime;
        }
    }
}