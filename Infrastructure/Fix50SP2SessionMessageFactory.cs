using PureFix.Transport;
using PureFix.Types;
using PureFix.Types.Config;
using TradeCaptureDemo.Types.FIX50SP2TC;
using TradeCaptureDemo.Types.FIX50SP2TC.Components;

namespace TradeCaptureDemo.Infrastructure;

public class Fix50SP2SessionMessageFactory(ISessionDescription sessionDescription) : ISessionMessageFactory
{
    IFixMessage ISessionMessageFactory.TestRequest(string testReqId)
    {
        return new TestRequest { StandardHeader = new StandardHeader(), TestReqID = testReqId };
    }

    IFixMessage ISessionMessageFactory.Heartbeat(string testReqId)
    {
        return new Heartbeat { StandardHeader = new StandardHeader(), TestReqID = testReqId };
    }

    IFixMessage ISessionMessageFactory.ResendRequest(int beginSeqNo, int endSeqNo)
    {
        return new ResendRequest { StandardHeader = new StandardHeader(), BeginSeqNo = beginSeqNo, EndSeqNo = endSeqNo };
    }

    IFixMessage ISessionMessageFactory.SequenceReset(int newSeqNo, bool? gapFill)
    {
        return new SequenceReset { StandardHeader = new StandardHeader(), GapFillFlag = gapFill, NewSeqNo = newSeqNo };
    }

    IStandardTrailer ISessionMessageFactory.Trailer(int checksum)
    {
        return new StandardTrailer() { CheckSum = checksum.ToString("D3") };
    }

    IFixMessage ISessionMessageFactory.Logon(string? userRequestId, bool? isResponse)
    {
        return new Logon
        {
            Username = !string.IsNullOrEmpty(sessionDescription.Username) ? sessionDescription.Username : null,
            Password = !string.IsNullOrEmpty(sessionDescription.Password) ? sessionDescription.Password : null,
            HeartBtInt = sessionDescription.HeartBtInt,
            ResetSeqNumFlag = sessionDescription.ResetSeqNumFlag,
            EncryptMethod = 0
        };
    }

    IFixMessage ISessionMessageFactory.Reject(string msgType, int seqNo, string msg, int reason)
    {
        return new Reject
        {
            RefMsgType = msgType,
            SessionRejectReason = reason,
            RefSeqNum = seqNo,
            Text = msg
        };
    }

    IFixMessage ISessionMessageFactory.Logout(string text)
    {
        return new Logout
        {
            Text = text
        };
    }

    IStandardHeader ISessionMessageFactory.Header(string msgType, int seqNum, DateTime time, IStandardHeader? overrides)
    {
        var bodyLength = Math.Max(4, sessionDescription.BodyLengthChars ?? 7);
        var placeholder = (int)Math.Pow(10, bodyLength - 1) + 1;
        return new StandardHeader
        {
            BeginString = sessionDescription.BeginString,
            BodyLength = placeholder,
            MsgType = msgType,
            SenderCompID = sessionDescription.SenderCompID,
            MsgSeqNum = seqNum,
            SendingTime = time,
            TargetCompID = sessionDescription.TargetCompID,
            TargetSubID = !string.IsNullOrEmpty(sessionDescription.TargetSubID) ? sessionDescription.TargetSubID : "TargetSubID",
            SenderSubID = !string.IsNullOrEmpty(sessionDescription.SenderSubID) ? sessionDescription.SenderSubID : "SenderSubID"
        };
    }
}
