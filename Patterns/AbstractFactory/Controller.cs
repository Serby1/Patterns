using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.BaseManagement;

namespace AbstractFactory
{
    public class Controller
    {
        RaceFactory race; // фабрика, отвечающая за создание игровых юнитов. 
        public Controller(RaceFactory race)
        {
            this.race = race;
        }
        /// <summary>
        /// "Игра"
        /// </summary>
        public void PlayGame()
        {
            // Создаем юниты. Процесс создания юнитов не зависит от их расы.
            Artillery artillery = race.CreateArtillery();
            Infantry infantry = race.CreateInfantry();
            Tank tank = race.CreateTank();

            // Отдаем им какие-либо команды. Процесс управления юнитами не 
            // зависит от их расы.
            artillery.Disguise();
            infantry.Shoot();
            tank.Repair();
        }
    }
}
