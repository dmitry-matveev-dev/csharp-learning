static class LogLine
{
    public static string Message(string logLine)
    {
        int pos = logLine.IndexOf(":");
        string text = logLine.Substring(pos+1).Trim();
        return text;
    }

    public static string LogLevel(string logLine)
    {
       int start = logLine.IndexOf('[');
       int end = logLine.IndexOf(']');
        string text = logLine.Substring(start + 1, end - start - 1).Trim();
        string finalText = text.ToLower();
        return finalText;
    }

    public static string Reformat(string logLine)
    {
        int pos = logLine.IndexOf(":");
        string text = logLine.Substring(pos + 1).Trim();

        int start = logLine.IndexOf("[");
        int end = logLine.IndexOf("]");
        string secondText = logLine.Substring(start+1, end-start-1).Trim();
        string finalSecondText = secondText.ToLower();

        return $"{text} ({finalSecondText})";
    }
}
