/*
 * Copyright (c) 2026 Legion Builds
 * All rights reserved.
 *
 * - Redistribution and use in source and binary forms, with or without
 *   modification, are permitted provided that the following conditions are met:
 *
 * - Redistributions of source code must retain the above copyright notice, this
 *   list of conditions and the following disclaimer.
 * - Neither the name of the copyright holder nor the names
 *   of its contributors may be used to endorse or promote products derived from
 *   this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 */

namespace OpenMetaverse.Packets
{
    // Temporary stub so the tests compile before the packet is generated: every member returns a
    // default value. Removed by the commit that adds the message to the template and regenerates.
    public sealed class GameControlDataPacket : Packet
    {
        public sealed class AgentDataBlock
        {
            public UUID AgentID;
            public UUID SessionID;
            public byte Packet;
            public byte ActionMode;
        }

        public sealed class AxesBlock { public short Value; }
        public sealed class ButtonsBlock { public uint Flags; }
        public sealed class ModeAxesBlock { public short Value; }
        public sealed class ModeButtonsBlock { public uint Flags; }

        public AgentDataBlock AgentData = new AgentDataBlock();
        public AxesBlock[] Axes = new AxesBlock[0];
        public ButtonsBlock[] Buttons = new ButtonsBlock[0];
        public ModeAxesBlock[] ModeAxes = new ModeAxesBlock[0];
        public ModeButtonsBlock[] ModeButtons = new ModeButtonsBlock[0];

        public GameControlDataPacket()
        {
            Header = new Header();
        }

        public override int Length { get { return 0; } }
        public override void FromBytes(byte[] bytes, ref int i, ref int packetEnd, byte[] zeroBuffer) { }
        public override void FromBytes(Header header, byte[] bytes, ref int i) { }
        public override byte[] ToBytes() { return new byte[7]; }
        public override byte[][] ToBytesMultiple() { return new byte[0][]; }
    }
}
