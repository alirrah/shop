let popup = document.querySelector(".popup");

if (popup != null) {
    popup.style.display = "flex";

    let card = document.querySelector(".popup .card");

    let select = false;

    card.addEventListener("click", () => {
        select = true;
    });

    popup.addEventListener("click", () => {
        if (select) {
            select = false;
            return;
        }
        popup.style.display = "none";
    });
}