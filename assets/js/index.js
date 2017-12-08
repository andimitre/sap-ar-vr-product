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
  var img = $("#chap-2-img-2");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
    img.removeClass("hide");
  } else {
    elem.addClass("hide");
    img.removeClass("hide");
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
  var cover = $("#chap-2-img-2");
  if (elem.hasClass("hide")) {
    elem.removeClass("hide");
    cover.addClass("hide");
  } else {
    elem.addClass("hide");
    cover.removeClass("hide");
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

function hover(elem) {
  $(elem).css('cursor', 'pointer');
}

function addVideo() {
  var icon = $("#chap-2-img-icon");
  var original_img = $("#chap-2-img-1");
  if (icon.hasClass("hide")) {
    icon.removeClass("hide");
    original_img.addClass("hide");
  } else {
    icon.addClass("hide");
    original_img.removeClass("hide");
  }
  $("#add-video").val("");
}
