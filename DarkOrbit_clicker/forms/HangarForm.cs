using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkOrbit_clicker
{
    public partial class HangarForm : Form
        // Левая панель отображает изображение вашего выбранного корабля и его статистику, а так же изображение ПЕТА.
        // Центральная панель отображает вооружение корабля, дроидов и пета(в зависимости от выбранной вкладки (слоты в виде ячеек) принимают 
        // соответствующие предметы с инвентаря.
        // Справа от центральной панельки находится инвентарь пользователя
        // Правая панель отображает информацию о ваших кораблях , которые можно поменять кликнув по соответствующему кораблю.

    {
        public HangarForm()
        {
            InitializeComponent();
            if (AuthService.currentUser.currentSpaceship != null)
            {
                ShowSpaceship(AuthService.currentUser.currentSpaceship);
            }
        }

        // Метод принимает Spaceship, ничего не возвращает. 
        // Используется для того, чтобы вывести информацию о отправленном в него корабле.
        // Вызываться должен только из этой формы - при первом её открытии и при изменении корабля.
        private void ShowSpaceship(SpaceshipEntity spaceship)
        {
            pbx_shipImage.BackgroundImage = spaceship.image;
            lbl_shipStats.Text =
            spaceship.name + "\n" +
                "Lasers: " + spaceship.lasersMax + "\n" +
                "Shields: " + spaceship.shieldsMax;
        }

        private void Hangar_Load(object sender, EventArgs e)
        {

        }
    }
}
