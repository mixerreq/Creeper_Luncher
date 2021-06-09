using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.IO.Compression;

namespace Test_MC_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                panel2.Show();
                label4.Text = "Witaj, " + textBox1.Text + "!";
            }
            else
            {
                MessageBox.Show("Proszę wpisać nazwę użytkownika!");
            };
        }
        public void mc1132run()
        {
            ProcessStartInfo mc1132 = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Java\jre1.8.0_281\bin\javaw.exe",
                CreateNoWindow = false,
                Arguments = @"-Xmx1G -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Dorg.lwjgl.util.Debug=true -Dorg.lwjgl.util.DebugLoader=true -Djava.library.path=" + label2.Text + @"\.minecraft\versions\1.13.2\natives -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=unknown -cp " + label2.Text + @"\.minecraft\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" + label2.Text + @"\.minecraft\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" + label2.Text + @"\.minecraft\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" + label2.Text + @"\.minecraft\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" + label2.Text + @"\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + label2.Text + @"\.minecraft\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;" + label2.Text + @"\.minecraft\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" + label2.Text + @"\.minecraft\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" + label2.Text + @"\.minecraft\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" + label2.Text + @"\.minecraft\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + label2.Text + @"\.minecraft\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\brigadier\1.0.14\brigadier-1.0.14.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\datafixerupper\1.0.19\datafixerupper-1.0.19.jar;" + label2.Text + @"\.minecraft\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" + label2.Text + @"\.minecraft\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" + label2.Text + @"\.minecraft\libraries\it\unimi\dsi\fastutil\8.2.1\fastutil-8.2.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\realms\1.13.9\realms-1.13.9.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl\3.1.6\lwjgl-3.1.6.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-jemalloc\3.1.6\lwjgl-jemalloc-3.1.6.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-openal\3.1.6\lwjgl-openal-3.1.6.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-opengl\3.1.6\lwjgl-opengl-3.1.6.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-glfw\3.1.6\lwjgl-glfw-3.1.6.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-stb\3.1.6\lwjgl-stb-3.1.6.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;" + label2.Text + @"\.minecraft\versions\1.13.2\1.13.2.jar net.minecraft.client.main.Main --username " + textBox1.Text + @" --version 1.13.2 --gameDir " + label2.Text + @"\.minecraft --assetsDir " + label2.Text + @"\.minecraft\assets --assetIndex 1.13.1 --uuid 4a1a6094baea35cbac2f33afc395f58b --accessToken 1337535510N --userType legacy --versionType release",
            };
            Process.Start(mc1132);
        }
        public void mc1165run()
        {
            ProcessStartInfo mc1165 = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Java\jre1.8.0_281\bin\javaw.exe",
                CreateNoWindow = false,
                Arguments = @"-Xmx1G -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=" + label2.Text + @"\.minecraft\versions\1.16.5\natives -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=unknown -cp " + label2.Text + @"\.minecraft\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" + label2.Text + @"\.minecraft\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;" + label2.Text + @"\.minecraft\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" + label2.Text + @"\.minecraft\libraries\com\ibm\icu\icu4j\66.1\icu4j-66.1.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\javabridge\1.0.22\javabridge-1.0.22.jar;" + label2.Text + @"\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;" + label2.Text + @"\.minecraft\libraries\io\netty\netty-all\4.1.25.Final\netty-all-4.1.25.Final.jar;" + label2.Text + @"\.minecraft\libraries\com\google\guava\guava\21.0\guava-21.0.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;" + label2.Text + @"\.minecraft\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;" + label2.Text + @"\.minecraft\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;" + label2.Text + @"\.minecraft\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + label2.Text + @"\.minecraft\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\brigadier\1.0.17\brigadier-1.0.17.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\datafixerupper\4.0.26\datafixerupper-4.0.26.jar;" + label2.Text + @"\.minecraft\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\authlib\2.1.28\authlib-2.1.28.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" + label2.Text + @"\.minecraft\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" + label2.Text + @"\.minecraft\libraries\it\unimi\dsi\fastutil\8.2.1\fastutil-8.2.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl\3.2.2\lwjgl-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-jemalloc\3.2.2\lwjgl-jemalloc-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-openal\3.2.2\lwjgl-openal-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-opengl\3.2.2\lwjgl-opengl-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-glfw\3.2.2\lwjgl-glfw-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-stb\3.2.2\lwjgl-stb-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl-tinyfd\3.2.2\lwjgl-tinyfd-3.2.2.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\text2speech\1.11.3\text2speech-1.11.3.jar;" + label2.Text + @"\.minecraft\versions\1.16.5\1.16.5.jar net.minecraft.client.main.Main --username " + textBox1.Text + @" --version 1.16.5 --gameDir " + label2.Text + @"\.minecraft --assetsDir " + label2.Text + @"\.minecraft\assets --assetIndex 1.16 --uuid 4a1a6094baea35cbac2f33afc395f58b --accessToken 1337535510N --userType legacy --versionType release",
            };
            Process.Start(mc1165);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void mc1122run()
        {
            ProcessStartInfo mc1122 = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Java\jre1.8.0_281\bin\javaw.exe",
                CreateNoWindow = false,
                Arguments = @"-Xmx1G -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path="+label2.Text+@"\.minecraft\versions\1.12.2\natives -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=unknown -Dminecraft.client.jar="+label2.Text+@"\.minecraft\versions\1.12.2\1.12.2.jar -cp "+label2.Text+@"\.minecraft\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;"+label2.Text+@"\.minecraft\libraries\net\java\dev\jna\jna\4.4.0\jna-4.4.0.jar;"+label2.Text+@"\.minecraft\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;"+label2.Text+@"\.minecraft\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;"+label2.Text+@"\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\5.0.3\jopt-simple-5.0.3.jar;"+label2.Text+@"\.minecraft\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;"+label2.Text+@"\.minecraft\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;"+label2.Text+@"\.minecraft\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;"+label2.Text+@"\.minecraft\libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;"+label2.Text+@"\.minecraft\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;"+label2.Text+@"\.minecraft\libraries\io\netty\netty-all\4.1.9.Final\netty-all-4.1.9.Final.jar;"+label2.Text+@"\.minecraft\libraries\com\google\guava\guava\21.0\guava-21.0.jar;"+label2.Text+@"\.minecraft\libraries\org\apache\commons\commons-lang3\3.5\commons-lang3-3.5.jar;"+label2.Text+@"\.minecraft\libraries\commons-io\commons-io\2.5\commons-io-2.5.jar;"+label2.Text+@"\.minecraft\libraries\commons-codec\commons-codec\1.10\commons-codec-1.10.jar;"+label2.Text+@"\.minecraft\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;"+label2.Text+@"\.minecraft\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;"+label2.Text+@"\.minecraft\libraries\com\google\code\gson\gson\2.8.0\gson-2.8.0.jar;"+label2.Text+@"\.minecraft\libraries\com\mojang\authlib\1.5.25\authlib-1.5.25.jar;"+label2.Text+@"\.minecraft\libraries\com\mojang\realms\1.10.22\realms-1.10.22.jar;"+label2.Text+@"\.minecraft\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;"+label2.Text+@"\.minecraft\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;"+label2.Text+@"\.minecraft\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;"+label2.Text+@"\.minecraft\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;"+label2.Text+@"\.minecraft\libraries\it\unimi\dsi\fastutil\7.1.0\fastutil-7.1.0.jar;"+label2.Text+@"\.minecraft\libraries\org\apache\logging\log4j\log4j-api\2.8.1\log4j-api-2.8.1.jar;"+label2.Text+@"\.minecraft\libraries\org\apache\logging\log4j\log4j-core\2.8.1\log4j-core-2.8.1.jar;"+label2.Text+@"\.minecraft\libraries\org\lwjgl\lwjgl\lwjgl\2.9.4-nightly-20150209\lwjgl-2.9.4-nightly-20150209.jar;"+label2.Text+@"\.minecraft\libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.4-nightly-20150209\lwjgl_util-2.9.4-nightly-20150209.jar;"+label2.Text+@"\.minecraft\libraries\com\mojang\text2speech\1.10.3\text2speech-1.10.3.jar;"+label2.Text+@"\.minecraft\versions\1.12.2\1.12.2.jar net.minecraft.client.main.Main --username "+textBox1.Text+@" --version 1.12.2 --gameDir "+label2.Text+@"\.minecraft --assetsDir "+label2.Text+@"\.minecraft\assets --assetIndex 1.12 --uuid 4a1a6094baea35cbac2f33afc395f58b --accessToken 1337535510N --userType legacy --versionType release",
            };
            Process.Start(mc1122);
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nazwa Użytkownika")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "Nazwa Użytkownika";
            }
        }
        public void mc185run()
        {
            ProcessStartInfo mc185 = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Java\jre1.8.0_281\bin\javaw.exe",
                CreateNoWindow = false,
                Arguments = @"-Xmx1G -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M -XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump -Djava.library.path=" + label2.Text + @"\.minecraft\versions\1.8.5\natives -Dminecraft.launcher.brand=java-minecraft-launcher -Dminecraft.launcher.version=unknown -Dminecraft.client.jar=" + label2.Text + @"\.minecraft\versions\1.8.5\1.8.5.jar -cp " + label2.Text + @"\.minecraft\libraries\oshi-project\oshi-core\1.1\oshi-core-1.1.jar;" + label2.Text + @"\.minecraft\libraries\net\java\dev\jna\jna\3.4.0\jna-3.4.0.jar;" + label2.Text + @"\.minecraft\libraries\net\java\dev\jna\platform\3.4.0\platform-3.4.0.jar;" + label2.Text + @"\.minecraft\libraries\com\ibm\icu\icu4j-core-mojang\51.2\icu4j-core-mojang-51.2.jar;" + label2.Text + @"\.minecraft\libraries\net\sf\jopt-simple\jopt-simple\4.6\jopt-simple-4.6.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + label2.Text + @"\.minecraft\libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + label2.Text + @"\.minecraft\libraries\io\netty\netty-all\4.0.23.Final\netty-all-4.0.23.Final.jar;" + label2.Text + @"\.minecraft\libraries\com\google\guava\guava\17.0\guava-17.0.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\commons\commons-lang3\3.3.2\commons-lang3-3.3.2.jar;" + label2.Text + @"\.minecraft\libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + label2.Text + @"\.minecraft\libraries\commons-codec\commons-codec\1.9\commons-codec-1.9.jar;" + label2.Text + @"\.minecraft\libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + label2.Text + @"\.minecraft\libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + label2.Text + @"\.minecraft\libraries\com\google\code\gson\gson\2.2.4\gson-2.2.4.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\authlib\1.5.21\authlib-1.5.21.jar;" + label2.Text + @"\.minecraft\libraries\com\mojang\realms\1.7.18\realms-1.7.18.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\commons\commons-compress\1.8.1\commons-compress-1.8.1.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\httpcomponents\httpclient\4.3.3\httpclient-4.3.3.jar;" + label2.Text + @"\.minecraft\libraries\commons-logging\commons-logging\1.1.3\commons-logging-1.1.3.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\httpcomponents\httpcore\4.3.2\httpcore-4.3.2.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\logging\log4j\log4j-api\2.0-beta9\log4j-api-2.0-beta9.jar;" + label2.Text + @"\.minecraft\libraries\org\apache\logging\log4j\log4j-core\2.0-beta9\log4j-core-2.0-beta9.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl\lwjgl\2.9.4-nightly-20150209\lwjgl-2.9.4-nightly-20150209.jar;" + label2.Text + @"\.minecraft\libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.4-nightly-20150209\lwjgl_util-2.9.4-nightly-20150209.jar;" + label2.Text + @"\.minecraft\libraries\tv\twitch\twitch\6.5\twitch-6.5.jar;" + label2.Text + @"\.minecraft\versions\1.8.5\1.8.5.jar net.minecraft.client.main.Main --username " + textBox1.Text + @" --version 1.8.5 --gameDir " + label2.Text + @"\.minecraft --assetsDir " + label2.Text + @"\.minecraft\assets --assetIndex 1.8 --uuid 4a1a6094baea35cbac2f33afc395f58b --accessToken 1337535510N --userProperties {} --userType legacy",
            };
            Process.Start(mc185);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.mc1122 == true)
            {
                comboBox1.Items.Add("Wersja 1.12.2");
            }
            if (Properties.Settings.Default.mc1165 == true)
            {
                comboBox1.Items.Add("Wersja 1.16.5");
            }
            if (Properties.Settings.Default.mc1164 == true)
            {
                comboBox1.Items.Add("Wersja 1.16.4");
            }
            if (Properties.Settings.Default.mc1163 == true)
            {
                comboBox1.Items.Add("Wersja 1.16.3");
            }
            if (Properties.Settings.Default.mc1162 == true)
            {
                comboBox1.Items.Add("Wersja 1.16.2");
            }
            if (Properties.Settings.Default.mc1161 == true)
            {
                comboBox1.Items.Add("Wersja 1.16.1");
            }
            if (Properties.Settings.Default.mc116 == true)
            {
                comboBox1.Items.Add("Wersja 1.16");
            }
            if (Properties.Settings.Default.mc1152 == true)
            {
                comboBox1.Items.Add("Wersja 1.15.2");
            }
            if (Properties.Settings.Default.mc1151 == true)
            {
                comboBox1.Items.Add("Wersja 1.15.1");
            }
            if (Properties.Settings.Default.mc115 == true)
            {
                comboBox1.Items.Add("Wersja 1.15");
            }
            if (Properties.Settings.Default.mc1144 == true)
            {
                comboBox1.Items.Add("Wersja 1.14.4");
            }
            if (Properties.Settings.Default.mc1143 == true)
            {
                comboBox1.Items.Add("Wersja 1.14.3");
            }
            if (Properties.Settings.Default.mc1142 == true)
            {
                comboBox1.Items.Add("Wersja 1.14.2");
            }
            if (Properties.Settings.Default.mc1141 == true)
            {
                comboBox1.Items.Add("Wersja 1.14.1");
            }
            if (Properties.Settings.Default.mc114 == true)
            {
                comboBox1.Items.Add("Wersja 1.14");
            }
            if (Properties.Settings.Default.mc1132 == true)
            {
                comboBox1.Items.Add("Wersja 1.13.2");
            }
            if (Properties.Settings.Default.mc1131 == true)
            {
                comboBox1.Items.Add("Wersja 1.13.1");
            }
            if (Properties.Settings.Default.mc113 == true)
            {
                comboBox1.Items.Add("Wersja 1.13");
            }
            if (Properties.Settings.Default.mc1121 == true)
            {
                comboBox1.Items.Add("Wersja 1.12.1");
            }
            if (Properties.Settings.Default.mc112 == true)
            {
                comboBox1.Items.Add("Wersja 1.12");
            }
            if (Properties.Settings.Default.mc1112 == true)
            {
                comboBox1.Items.Add("Wersja 1.11.2");
            }
            if (Properties.Settings.Default.mc1111 == true)
            {
                comboBox1.Items.Add("Wersja 1.11.1");
            }
            if (Properties.Settings.Default.mc111 == true)
            {
                comboBox1.Items.Add("Wersja 1.11");
            }
            if (Properties.Settings.Default.mc1102 == true)
            {
                comboBox1.Items.Add("Wersja 1.10.2");
            }
            if (Properties.Settings.Default.mc1101 == true)
            {
                comboBox1.Items.Add("Wersja 1.10.1");
            }
            if (Properties.Settings.Default.mc110 == true)
            {
                comboBox1.Items.Add("Wersja 1.10");
            }
            if (Properties.Settings.Default.mc194 == true)
            {
                comboBox1.Items.Add("Wersja 1.9.4");
            }
            if (Properties.Settings.Default.mc193 == true)
            {
                comboBox1.Items.Add("Wersja 1.9.3");
            }
            if (Properties.Settings.Default.mc192 == true)
            {
                comboBox1.Items.Add("Wersja 1.9.2");
            }
            if (Properties.Settings.Default.mc191 == true)
            {
                comboBox1.Items.Add("Wersja 1.9.1");
            }
            if (Properties.Settings.Default.mc19 == true)
            {
                comboBox1.Items.Add("Wersja 1.9");
            }
            if (Properties.Settings.Default.mc189 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.9");
            }
            if (Properties.Settings.Default.mc188 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.8");
            }
            if (Properties.Settings.Default.mc187 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.7");
            }
            if (Properties.Settings.Default.mc186 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.6");
            }
            if (Properties.Settings.Default.mc185 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.5");
            }
            if (Properties.Settings.Default.mc184 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.4");
            }
            if (Properties.Settings.Default.mc183 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.3");
            }
            if (Properties.Settings.Default.mc182 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.2");
            }
            if (Properties.Settings.Default.mc181 == true)
            {
                comboBox1.Items.Add("Wersja 1.8.1");
            }
            if (Properties.Settings.Default.mc18 == true)
            {
                comboBox1.Items.Add("Wersja 1.8");
            }
            if (Properties.Settings.Default.mc1710 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.10");
            }
            if (Properties.Settings.Default.mc179 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.9");
            }
            if (Properties.Settings.Default.mc178 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.8");
            }
            if (Properties.Settings.Default.mc177 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.7");
            }
            if (Properties.Settings.Default.mc176 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.6");
            }
            if (Properties.Settings.Default.mc175 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.5");
            }
            if (Properties.Settings.Default.mc174 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.4");
            }
            if (Properties.Settings.Default.mc172 == true)
            {
                comboBox1.Items.Add("Wersja 1.7.2");
            }
            if (Properties.Settings.Default.mc164 == true)
            {
                comboBox1.Items.Add("Wersja 1.6.4");
            }
            if (Properties.Settings.Default.mc162 == true)
            {
                comboBox1.Items.Add("Wersja 1.6.2");
            }
            if (Properties.Settings.Default.mc161 == true)
            {
                comboBox1.Items.Add("Wersja 1.6.1");
            }
            if (Properties.Settings.Default.mc152 == true)
            {
                comboBox1.Items.Add("Wersja 1.5.2");
            }
            if (Properties.Settings.Default.mc151 == true)
            {
                comboBox1.Items.Add("Wersja 1.5.1");
            }
            if (Properties.Settings.Default.mc15 == true)
            {
                comboBox1.Items.Add("Wersja 1.5");
            }
            if (Properties.Settings.Default.mc147 == true)
            {
                comboBox1.Items.Add("Wersja 1.4.7");
            }
            if (Properties.Settings.Default.mc146 == true)
            {
                comboBox1.Items.Add("Wersja 1.4.6");
            }
            if (Properties.Settings.Default.mc145 == true)
            {
                comboBox1.Items.Add("Wersja 1.4.5");
            }
            if (Properties.Settings.Default.mc144 == true)
            {
                comboBox1.Items.Add("Wersja 1.4.4");
            }
            if (Properties.Settings.Default.mc142 == true)
            {
                comboBox1.Items.Add("Wersja 1.4.2");
            }
            if (Properties.Settings.Default.mc132 == true)
            {
                comboBox1.Items.Add("Wersja 1.3.2");
            }
            if (Properties.Settings.Default.mc131 == true)
            {
                comboBox1.Items.Add("Wersja 1.3.1");
            }
            if (Properties.Settings.Default.mc125 == true)
            {
                comboBox1.Items.Add("Wersja 1.2.5");
            }
            if (Properties.Settings.Default.mc124 == true)
            {
                comboBox1.Items.Add("Wersja 1.2.4");
            }
            if (Properties.Settings.Default.mc123 == true)
            {
                comboBox1.Items.Add("Wersja 1.2.3");
            }
            if (Properties.Settings.Default.mc122 == true)
            {
                comboBox1.Items.Add("Wersja 1.2.2");
            }
            if (Properties.Settings.Default.mc121 == true)
            {
                comboBox1.Items.Add("Wersja 1.2.1");
            }
            if (Properties.Settings.Default.mc11 == true)
            {
                comboBox1.Items.Add("Wersja 1.1");
            }
            if (Properties.Settings.Default.mc10 == true)
            {
                comboBox1.Items.Add("Wersja 1.0");
            }
            if (Properties.Settings.Default.Wersja == "1.8.5")
            {
                comboBox1.Text = "Wersja 1.8.5";
            }
            if (Properties.Settings.Default.Wersja == "1.13.2")
            {
                comboBox1.Text = "Wersja 1.13.2";
            }
            if (Properties.Settings.Default.Wersja == "1.17")
            {
                comboBox1.Text = "Wersja 1.17";
            }
    
            panel3.Hide();
            panel2.Hide();
            label2.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            label2.Hide();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://miki-company.wixsite.com/mikigames");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Wersja 1.16.5")
            {
                mc1165run();
            };
            if (comboBox1.Text == "Wersja 1.13.2")
            {
                mc1132run();
            };
            if (comboBox1.Text == "Wersja 1.8.5")
            {
                mc185run();
            };
            if (comboBox1.Text == "Wersja 1.12.2")
            {
                mc1122run();
            }
            if (comboBox1.Text == "Wersja 1.16.4")
            {
                
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Nazwa Użytkownika";
            panel2.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Wersja 1.16.5")
            {
                Properties.Settings.Default.Wersja = "1.16.5";
                Properties.Settings.Default.Save();
            };
            if (comboBox1.Text == "Wersja 1.16.4")
            {
                Properties.Settings.Default.Wersja = "1.16.4";
                Properties.Settings.Default.Save();
            };
            if (comboBox1.Text == "Wersja 1.16.3")
            {
                Properties.Settings.Default.Wersja = "1.16.3";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.16.2")
            {
                Properties.Settings.Default.Wersja = "1.16.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.16.1")
            {
                Properties.Settings.Default.Wersja = "1.16.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.16")
            {
                Properties.Settings.Default.Wersja = "1.16";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.15.2")
            {
                Properties.Settings.Default.Wersja = "1.15.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.15.1")
            {
                Properties.Settings.Default.Wersja = "1.15.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.15")
            {
                Properties.Settings.Default.Wersja = "1.15";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.14.4")
            {
                Properties.Settings.Default.Wersja = "1.14.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.14.3")
            {
                Properties.Settings.Default.Wersja = "1.14.3";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.14.2")
            {
                Properties.Settings.Default.Wersja = "1.14.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.14.1")
            {
                Properties.Settings.Default.Wersja = "1.14.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.14")
            {
                Properties.Settings.Default.Wersja = "1.14";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.13.2")
            {
                Properties.Settings.Default.Wersja = "1.13.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.13.1")
            {
                Properties.Settings.Default.Wersja = "1.13.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.13")
            {
                Properties.Settings.Default.Wersja = "1.13";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.12.2")
            {
                Properties.Settings.Default.Wersja = "1.12.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.12.1")
            {
                Properties.Settings.Default.Wersja = "1.12.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.12")
            {
                Properties.Settings.Default.Wersja = "1.12";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.11.2")
            {
                Properties.Settings.Default.Wersja = "1.11.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.11.1")
            {
                Properties.Settings.Default.Wersja = "1.11.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.11")
            {
                Properties.Settings.Default.Wersja = "1.11";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.10.2")
            {
                Properties.Settings.Default.Wersja = "1.10.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.10.1")
            {
                Properties.Settings.Default.Wersja = "1.10.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.10")
            {
                Properties.Settings.Default.Wersja = "1.10";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.9.4")
            {
                Properties.Settings.Default.Wersja = "1.9.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.9.3")
            {
                Properties.Settings.Default.Wersja = "1.9.3";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.9.2")
            {
                Properties.Settings.Default.Wersja = "1.9.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.9.1")
            {
                Properties.Settings.Default.Wersja = "1.9.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.9")
            {
                Properties.Settings.Default.Wersja = "1.9";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.9")
            {
                Properties.Settings.Default.Wersja = "1.8.9";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.8")
            {
                Properties.Settings.Default.Wersja = "1.8.8";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.7")
            {
                Properties.Settings.Default.Wersja = "1.8.7";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.6")
            {
                Properties.Settings.Default.Wersja = "1.8.6";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.5")
            {
                Properties.Settings.Default.Wersja = "1.8.5";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.4")
            {
                Properties.Settings.Default.Wersja = "1.8.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.3")
            {
                Properties.Settings.Default.Wersja = "1.8.3";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.2")
            {
                Properties.Settings.Default.Wersja = "1.8.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8.1")
            {
                Properties.Settings.Default.Wersja = "1.8.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.8")
            {
                Properties.Settings.Default.Wersja = "1.8";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.10")
            {
                Properties.Settings.Default.Wersja = "1.7.10";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.9")
            {
                Properties.Settings.Default.Wersja = "1.7.9";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.8")
            {
                Properties.Settings.Default.Wersja = "1.7.8";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.7")
            {
                Properties.Settings.Default.Wersja = "1.7.7";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.6")
            {
                Properties.Settings.Default.Wersja = "1.7.6";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.5")
            {
                Properties.Settings.Default.Wersja = "1.7.5";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.4")
            {
                Properties.Settings.Default.Wersja = "1.7.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.7.2")
            {
                Properties.Settings.Default.Wersja = "1.7.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.6.4")
            {
                Properties.Settings.Default.Wersja = "1.6.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.6.2")
            {
                Properties.Settings.Default.Wersja = "1.6.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.6.1")
            {
                Properties.Settings.Default.Wersja = "1.6.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.5.2")
            {
                Properties.Settings.Default.Wersja = "1.5.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.5.1")
            {
                Properties.Settings.Default.Wersja = "1.5.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.5")
            {
                Properties.Settings.Default.Wersja = "1.5";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.4.7")
            {
                Properties.Settings.Default.Wersja = "1.4.7";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.4.6")
            {
                Properties.Settings.Default.Wersja = "1.4.6";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.4.5")
            {
                Properties.Settings.Default.Wersja = "1.4.5";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.4.4")
            {
                Properties.Settings.Default.Wersja = "1.4.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.4.2")
            {
                Properties.Settings.Default.Wersja = "1.4.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.3.2")
            {
                Properties.Settings.Default.Wersja = "1.3.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.3.1")
            {
                Properties.Settings.Default.Wersja = "1.3.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.2.5")
            {
                Properties.Settings.Default.Wersja = "1.2.5";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.2.4")
            {
                Properties.Settings.Default.Wersja = "1.2.4";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.2.3")
            {
                Properties.Settings.Default.Wersja = "1.2.3";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.2.2")
            {
                Properties.Settings.Default.Wersja = "1.2.2";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.2.1")
            {
                Properties.Settings.Default.Wersja = "1.2.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.1")
            {
                Properties.Settings.Default.Wersja = "1.1";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.0")
            {
                Properties.Settings.Default.Wersja = "1.0";
                Properties.Settings.Default.Save();
            }
            if (comboBox1.Text == "Wersja 1.17")
            {
                Properties.Settings.Default.Wersja = "1.17";
                Properties.Settings.Default.Save();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mediafire.com/folder/nutrltao8woo9/Minecraft+versions");
            panel3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        

        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Wersja 1.16.5")
            {
                installmc1165();
            }
            if (comboBox2.Text == "Wersja 1.12.2")
            {
                installmc1122();
            }
            if (comboBox2.Text == "Wersja 1.13.2")
            {
                installmc1132();
            }
        }
        public void installmc1122()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1122 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.12.2");
                File.Delete(openFileDialog1.FileName);
            }
        }

        public void installmc1132()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1132 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.13.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1165()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1165 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.16.5");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc117()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc117 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.17");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1164()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1164 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.16.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1163()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1163 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.16.3");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1162()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1162 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.16.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1161()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1161 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.16.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc116()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc116 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.16");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1152()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1152 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.15.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1151()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1151 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.15.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc115()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc115 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.15");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1144()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1144 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.14.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1143()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1143 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.14.3");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1142()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1142 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.14.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1141()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1141 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.14.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc114()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc114 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.14");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1131()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1131 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.13.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc113()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc113 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.13");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1121()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1121 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.12.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc112()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc112 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.12");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1112()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1112 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.11.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1111()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1111 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.11.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc111()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc111 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.11");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1102()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1102 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.10.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1101()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1101 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.10.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc110()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc110 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.10");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc194()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc194 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.9.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc193()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc193 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.9.3");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc192()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc192 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.9.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc191()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc191 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.9.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc19()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc19 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.9");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc189()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc189 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.9");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc188()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc188 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.8");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc187()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc187 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.7");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc186()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc186 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.6");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc185()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc185 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.5");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc184()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc184 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc183()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc183 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.3");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc182()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc182 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc181()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc181 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc18()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc18 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.8");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc1710()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc1710 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.10");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc179()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc179 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.9");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc178()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc178 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.8");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc177()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc177 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.7");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc176()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc176 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.6");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc175()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc175 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.5");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc174()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc174 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc172()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc172 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.7.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc164()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc164 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.6.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc162()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc162 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.6.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc161()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc161 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.6.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc152()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc152 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.5.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc151()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc151 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.5.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc15()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc15 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.5");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc147()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc147 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.4.7");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc146()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc146 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.4.6");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc145()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc145 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.4.5");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc144()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc144 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.4.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc142()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc142 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.4.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc132()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc132 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.3.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc131()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc131 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.3.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc125()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc125 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.2.5");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc124()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc124 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.2.4");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc123()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc123 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.2.3");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc122()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc122 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.2.2");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc121()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc121 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.2.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc11()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc11 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.1");
                File.Delete(openFileDialog1.FileName);
            }

        }
        public void installmc10()
        {
            string title = "Creeper Launcher";
            string message = "Pomyślnie zainstalowano!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();

                string startPath = label2.Text + @"\.minecraft\versions";
                string zipPath = openFileDialog1.FileName;
                string extractPath = label2.Text + @"\.minecraft\versions\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Properties.Settings.Default.mc10 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                comboBox1.Items.Add("Wersja 1.0");
                File.Delete(openFileDialog1.FileName);
            }

        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            panel3.Hide();
        }
    }
}
 
   
 