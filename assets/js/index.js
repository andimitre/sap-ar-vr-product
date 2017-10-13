function chapter1(element) {
  var elem = $("#chap-1");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
  } else {
    elem.addClass("hide");
  }
}

function chapter2(element) {
  var elem = $("#chap-2");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
  } else {
    elem.addClass("hide");
  }
}

function chapter3(element) {
  var elem = $("#chap-3");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
  } else {
    elem.addClass("hide");
  }
}

function showImg() {
  var elem = $("#chap-2-img-1");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
  } else {
    elem.addClass("hide");
  }
  showContent();
}

function showContent() {
  var elem = $("#add-content");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
  } else {
    elem.addClass("hide");
  }
}

function addVideo() {
  var elem = $("#chap-2-img-2");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
  } else {
    elem.addClass("hide");
  }
  $("#add-video").val("");
}
