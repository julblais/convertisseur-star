using System.Collections.Generic;
using System.IO;
using STAR.Format;
using STAR.Writer;

namespace STAR.Tests
{
    public class RawWriter : IDocumentWriter
    {
        const string TEXT_CMD = "TEXT";
        const string NEWLINE_CMD = "NEWLINE";
        const string ITALICS_BEGIN_CMD = "BEGIN ITALICS";
        const string ITALICS_END_CMD = "END ITALICS";
        const string NEW_SECTION_CMD = "NEW SECTION";
        const char TAB = '\t';

        public string extension => "txt";

        public void WriteCommands(IEnumerable<Command> commands, TextWriter writer)
        {
            foreach (Command command in commands)
                WriteCommand(writer, command);
        }

        static void WriteCommand(TextWriter writer, in Command command)
        {
            switch (command.type)
            {
                case Command.Type.Text:
                    writer.WriteLine(TEXT_CMD);
                    writer.Write(TAB);
                    writer.WriteLine(command.text);
                    break;
                case Command.Type.Newline:
                    writer.WriteLine(NEWLINE_CMD);
                    break;
                case Command.Type.ItalicsBegin:
                    writer.WriteLine(ITALICS_BEGIN_CMD);
                    break;
                case Command.Type.ItalicsEnd:
                    writer.WriteLine(ITALICS_END_CMD);
                    break;
                case Command.Type.NewSection:
                    writer.WriteLine(NEW_SECTION_CMD);
                    break;
                default:
                    break;
            }
        }
    }
}