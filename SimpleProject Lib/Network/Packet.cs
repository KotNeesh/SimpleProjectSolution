using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace SimpleProject
{
    using SizePacket = UInt16;
    public class Packet
    {
        private Byte[] _data;
        private bool _sizeReady;
        private SizePacket _size;
        private SizePacket _pos;

        public Packet()
        {
            _data = new Byte[10];
            Clear();
        }
        public Packet(Byte[] data)
        {
            _data = data;
            _sizeReady = true;
            _size = (SizePacket)_data.Length;
            _pos = _size;
        }

        public void Clear()
        {
            _sizeReady = false;
            _size = 0;
            _pos = 0;
        }

        public bool IsReady
        {
            get
            {
                return _sizeReady && _pos == _size;
            }
        }
        public Byte[] GetData()
        {
            return _data;
        }
        public SizePacket Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        public SizePacket Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }
        public bool SizeReady
        {
            get
            {
                return _sizeReady;
            }
            set
            {
                _sizeReady = value;
                if (_sizeReady && _data.Length < _size)
                {
                    _data = new Byte[_size];
                }
            }
        }
    }
}
