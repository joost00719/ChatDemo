function scrollToBottom(elemSelector) {
    document.querySelector(elemSelector).scrollTo(0, document.querySelector(elemSelector).scrollHeight);
}