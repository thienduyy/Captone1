using System;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace IndentifiedFace.IO
{
    public sealed class SerialPortConn : IDisposable
    {
        private readonly SerialPort serialPort;

        private readonly string returnToken;

        private readonly string hookOpen;

        private readonly string hookClose;

        private bool disposed;

        public SerialPortConn(
            string comPort = "Com1",
            int baud = 2400,
            Parity parity = Parity.None,
            int dataBits = 8,
            StopBits stopBits = StopBits.One,
            string returnToken = "> ",
            string hookOpen = "",
            string hookClose = ""
            )
        {
            this.serialPort = new SerialPort(comPort, baud, parity, dataBits, stopBits)
            {
                ReadTimeout = 1000,
                RtsEnable = true,
                DtrEnable = true
            };

            this.returnToken = returnToken;
            if (hookOpen == "")
                this.hookOpen = null;
            else
                this.hookOpen = hookOpen;
            if (hookClose == "")
                this.hookClose = null;
            else
                this.hookClose = hookClose;
        }

        public bool OpenConnection()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot use a disposed object.");
            }

            try
            {
                this.serialPort.Open();
                this.serialPort.DiscardInBuffer();
                bool hooked = false;
                if (hookOpen != null)
                {
                    hooked = this.Hook();
                }
                else
                {
                    hooked = true;
                }
                if (hooked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot use a disposed object.");
            }

            try
            {
                bool unhooked = false;
                if (hookClose != null)
                {
                    unhooked = this.UnHook();
                }
                else
                {
                    unhooked = true;
                }
                if (unhooked)
                {
                    Thread.Sleep(100);
                    this.serialPort.ReadLine();
                    this.serialPort.DiscardInBuffer();
                    this.serialPort.Close();
                    this.serialPort.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot dispose of a disposed object.");
            }

            var closed = this.CloseConnection();
            if (closed)
            {
                this.disposed = true;
            }
            else
            {
                throw new Exception("Error! Could not close port!");
            }
        }

        private bool Hook()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot use a disposed object.");
            }

            try
            {
                this.serialPort.Write(hookOpen + "\r");
                Thread.Sleep(100);
                this.serialPort.DiscardInBuffer();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool UnHook()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot use a disposed object.");
            }

            try
            {
                this.serialPort.Write(hookClose + "\r");
                Thread.Sleep(100);
                this.serialPort.DiscardInBuffer();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string HookTest(string serialCommand)
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot use a disposed object.");
            }

            try
            {
                this.serialPort.Write(serialCommand + "\r");
                Thread.Sleep(100);
                bool loop = true;
                string output = "";
                while (loop)
                {
                    output += this.serialPort.ReadExisting();
                    if (output.EndsWith(this.returnToken))
                    {
                        break;
                    }
                }

                return output;
            }
            catch (TimeoutException e)
            {
                throw new Exception("Connection failed. Read timed out.");
            }
        }

        public string WriteConnection(string serialCommand, bool isSafe = false)
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.GetType().Name, "Cannot use a disposed object.");
            }

            if (isSafe)
            {
                var output = this.HookTest(serialCommand);
                return output;
            }
            else
            {
                try
                {
                    this.serialPort.Write(serialCommand + "\r");
                    Thread.Sleep(100);

                    return this.serialPort.ReadExisting();
                }
                catch (Exception e)
                {
                    throw new Exception("Connection failed. Timed out.");
                }
            }
        }
    }
}
