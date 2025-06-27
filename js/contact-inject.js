function injectWhatsappLink(elementId) {
    const whatsappNumber = "5573999585703";
    const url = `https://wa.me/${whatsappNumber}`;
    const el = document.getElementById(elementId);
    if (el) {
        el.setAttribute("href", url);
    }
}

function injectWhatsappText(elementId) {
    const formattedNumber = "(73) 9 9958-5703";
    const el = document.getElementById(elementId);
    if (el) {
        el.textContent = formattedNumber;
    }
}

window.injectWhatsappLink = injectWhatsappLink;
window.injectWhatsappText = injectWhatsappText;
