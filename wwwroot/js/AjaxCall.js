$("#LoadingStatus").html("Loading...");
$.get("/Players/GetPlayers", null, DataBind);
function DataBind(PlayersList) {
    var SetData = $("#SetPlayersList");
    for (var i = 0; i < PlayersList.length; i++) {
        var Data = `<div class="uk-width-large-1-4 uk-width-medium-1-2 uk-width-small-1-2 player-item ` + PlayersList[i].PositionId + `">
                                            <div class="player-article">
                                                <div class="wrapper">
                                                    <div class="img-wrap">
                                                        <div class="player-number">
                                                            <span>`+
            PlayersList[i].PlayerNumber +
            `</span>
                                                        </div>
                                                        <div class="bio">
                                                            <span>
                                                                <a href="/Players/Player/`+ PlayersList[i].Id + `">
                                                                    bio
                                                                </a>
                                                            </span>
                                                        </div>
                                                        <a asp-action="Details" asp-route-id="`+ PlayersList[i].Id + `">
                                                            <img src="images/`+ PlayersList[i].Photo + `" class="img-polaroid" alt="Benjamin Mendoza" title="Benjamin Mendoza">
                                                        </a>
                                                        <ul class="socials">
                                                            <li class="twitter">
                                                                <a href="http://twitter.com/" target="_blank" rel="nofollow">
                                                                </a>
                                                            </li>
                                                            <li class="facebook">
                                                                <a href="http://facebook.com/" target="_blank" rel="nofollow">
                                                                </a>
                                                            </li>
                                                            <li class="google-plus">
                                                                <a href="https://plus.google.com/" target="_blank" rel="nofollow">
                                                                </a>
                                                            </li>
                                                            <li class="pinterest">
                                                                <a href="https://www.pinterest.com" target="_blank" rel="nofollow">
                                                                </a>
                                                            </li>
                                                            <li class="linkedin">
                                                                <a href="https://www.linkedin.com" target="_blank" rel="nofollow">
                                                                </a>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <div class="info">
                                                        <div class="name">
                                                            <h3>
                                                                <a href="/Players/Player/`+ PlayersList[i].Id + `">
                                                                    `+ PlayersList[i].Name + `
                                                                </a>
                                                            </h3>
                                                        </div>
                                                        <div class="position">`
            + PlayersList[i].Position + `
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>`;
        SetData.append(Data);
        $("#LoadingStatus").html("");
    }
}