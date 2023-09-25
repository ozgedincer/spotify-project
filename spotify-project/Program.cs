using spotify_project;
using spotify_project.Entities;
using spotify_project.Services;

Console.WriteLine("SPOTIFY");

var song1 = new Song("Requem K.", "Mozart", "Orchestre national de France", null);
var song2 = new Song("Sonato", "Beethoven", "Fazıl Say", "Warner Music");

Playlist playlist = new Playlist(song1);
playlist.AddSong(song2);

playlist.ShuffleSongs();

NotepadService service = new NotepadService();

service.PlaylistToNotepad(playlist);
