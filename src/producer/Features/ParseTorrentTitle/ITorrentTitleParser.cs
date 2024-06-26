namespace Producer.Features.ParseTorrentTitle;

public interface ITorrentTitleParser
{
    ParsedFilename Parse(string name);
    TorrentType GetTypeByName(string name);
}
