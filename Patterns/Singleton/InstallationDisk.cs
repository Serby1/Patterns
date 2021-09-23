using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
	class InstallationDisk
	{

		/// Класс, описывающий диск зарезервированный под установку windows

		/// Статический lbcr
		
		static InstallationDisk disk;

		
		/// Конструктор класса помещен в защищенную область с тем, чтобы объекты 
		/// класса нельзя было создать обычным способом
		
		protected InstallationDisk()
		{
			Console.WriteLine("Выделен новый диск");
		}

		
		/// Создатель объектов класса
		
		/// <returns>Возвращается единственный объект</returns>
		public static InstallationDisk Instance()
		{
			// если игрока еще нет, то создаем его
			if (disk == null)
			{
				disk = new InstallationDisk();
			}
			return disk;
		}
	}
		
}
