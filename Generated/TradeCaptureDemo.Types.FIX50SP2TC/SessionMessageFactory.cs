using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PureFix.Types;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;
using PureFix.Types.Config;

namespace TradeCaptureDemo.Types.FIX50SP2TC
{
	public class SessionMessageFactory : ISessionMessageFactory
	{
		private readonly ISessionDescription m_SessionDescription;
		
		public SessionMessageFactory(ISessionDescription sessionDescription)
		{
			m_SessionDescription = sessionDescription;
		}
		
		IFixMessage? ISessionMessageFactory.TestRequest(string testReqId)
		{
			return new TestRequest { StandardHeader = new Components.StandardHeader(), TestReqID = testReqId };
		}
		
		IFixMessage? ISessionMessageFactory.Heartbeat(string testReqId)
		{
			return new Heartbeat { StandardHeader = new Components.StandardHeader(), TestReqID = testReqId };
		}
		
		IFixMessage? ISessionMessageFactory.ResendRequest(int beginSeqNo, int endSeqNo)
		{
			return new ResendRequest { StandardHeader = new Components.StandardHeader(), BeginSeqNo = beginSeqNo, EndSeqNo = endSeqNo };
		}
		
		IFixMessage? ISessionMessageFactory.SequenceReset(int newSeqNo, bool? gapFill)
		{
			return new SequenceReset { StandardHeader = new Components.StandardHeader(), GapFillFlag = gapFill, NewSeqNo = newSeqNo };
		}
		
		IStandardTrailer? ISessionMessageFactory.Trailer(int checksum)
		{
			return new Components.StandardTrailer() { CheckSum = checksum.ToString("D3") };
		}
		
		IFixMessage? ISessionMessageFactory.Logon(string? userRequestId, bool? isResponse)
		{
			return new Logon
			{
				Username = !string.IsNullOrEmpty(m_SessionDescription.Username) ? m_SessionDescription.Username : null,
				Password = !string.IsNullOrEmpty(m_SessionDescription.Password) ? m_SessionDescription.Password : null,
				HeartBtInt = m_SessionDescription.HeartBtInt,
				ResetSeqNumFlag = m_SessionDescription.ResetSeqNumFlag,
				EncryptMethod = 0
			}
			;
		}
		
		IFixMessage? ISessionMessageFactory.Reject(string msgType, int seqNo, string msg, int reason)
		{
			return new Reject
			{
				RefMsgType = msgType,
				SessionRejectReason = reason,
				RefSeqNum = seqNo,
				Text = msg
			}
			;
		}
		
		IFixMessage? ISessionMessageFactory.Logout(string text)
		{
			return new Logout
			{
				Text = text
			}
			;
		}
		
		IStandardHeader? ISessionMessageFactory.Header(string msgType, int seqNum, DateTime time, IStandardHeader? overrides)
		{
			var bodyLength = Math.Max(4, m_SessionDescription.BodyLengthChars ?? 7);
			var placeholder = (int)Math.Pow(10, bodyLength - 1) + 1;
			return new Components.StandardHeader
			{
				BeginString = m_SessionDescription.BeginString,
				BodyLength = placeholder,
				MsgType = msgType,
				SenderCompID = m_SessionDescription.SenderCompID,
				MsgSeqNum = seqNum,
				SendingTime = time,
				TargetCompID = m_SessionDescription.TargetCompID,
				TargetSubID = !string.IsNullOrEmpty(m_SessionDescription.TargetSubID) ? m_SessionDescription.TargetSubID : m_SessionDescription.TargetSubID,
				SenderSubID = !string.IsNullOrEmpty(m_SessionDescription.SenderSubID) ? m_SessionDescription.SenderSubID : m_SessionDescription.SenderSubID,
			}
			;
		}
	}
}
