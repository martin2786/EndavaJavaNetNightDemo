var pdf = require("html-pdf");

module.exports = result => {
  var html = "<h1> Hello Endava .net/Java Night";

  pdf.create(html).toStream(function(err, stream) {
    stream.pipe(result.stream);
  });
};



