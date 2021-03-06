﻿/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2015 Kyle Speck (kojasou@hybrasyl.com)
 *
 * Authors:   Kyle Speck    <kojasou@hybrasyl.com>
 *
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace HybrasylEditor.UI
{
    public partial class NewMapForm : Form
    {
        private Map map;

        public NewMapForm()
        {
            string localStorage = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string mapPath = localStorage + @"\VirtualStore\Program Files (x86)\KRU\Dark Ages\maps\lod500.map";

            InitializeComponent();

            this.map = new Map() { Width = 100, Height = 100 };
            this.map.SetData(File.ReadAllBytes(mapPath));
            
            this.propertyGrid1.SelectedObject = map;

            this.mapPanel.Map = map;
        }

        private void showFloorButton_Click(object sender, EventArgs e)
        {
            mapPanel.ShowFloor = showFloorButton.Checked;
        }
        private void showLeftWallButton_Click(object sender, EventArgs e)
        {
            mapPanel.ShowLeftWalls = showLeftWallButton.Checked;
        }
        private void showRightWallButton_Click(object sender, EventArgs e)
        {
            mapPanel.ShowRightWalls = showRightWallButton.Checked;
        }
        private void showNpcButton_Click(object sender, EventArgs e)
        {
            mapPanel.ShowNpcs = showNpcButton.Checked;
        }
    }
}
