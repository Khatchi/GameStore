using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<GameDtos> games = [
    new (
        1,
        "Street Fighting II",
        "Fighting",
        19.99M,
        new DateOnly(1992, 7, 15)),
        new (
        2,
        "Final Fantasy XIV",
        "Roleplaying",
        59.99M,
        new DateOnly(2010, 9, 30)),
        new (
        3,
        "FIFA 23",
        "Sports",
        69.99M,
        new DateOnly(2022, 9, 27))
];

// GET /games
app.MapGet("games", () => games);

// GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id));

app.Run();