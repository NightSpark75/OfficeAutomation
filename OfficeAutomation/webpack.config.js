const path = require('path');
module.exports = {
  mode: 'development',
  entry: { 'main': './js/app.jsx' },
  output: {
    path: path.resolve(__dirname, './Scripts/dist'),
    filename: 'bundle.js',
    publicPath: './Scripts/dist'
  },
  module: {
    rules: [
      {
        test: /\.jsx$/,
        exclude: /(node_modules)/,
        use: {
          loader: 'babel-loader',
          options: {
            presets: [
              '@babel/preset-react',
              '@babel/preset-env'
            ]
          }
        }
      },
      {
        test: /\.css/,
        use: [
          { loader: 'style-loader' },
          { loader: 'css-loader' }
        ]
      }
    ]
  }
};