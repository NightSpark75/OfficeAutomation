var webpack = require('webpack')
var path = require('path')
var outFolder = path.resolve(__dirname, './Scripts/dist')
var isProduction = process.env.NODE_ENV === 'prodcution'
var jsxLoaders = isProduction ?
    ['babel-loader?presets[]=es2015,presets[]=react'] :
    ['react-hot-loader/webpack', 'babel-loader?presets[]=es2015,presets[]=react']; // only react hot load in debug build
var entryPoint = './js/app.jsx';  
var app = isProduction ? [entryPoint] : [  
    'webpack-dev-server/client?http://0.0.0.0:3000', // WebpackDevServer host and port
    'webpack/hot/only-dev-server', // "only" prevents reload on syntax errors
    entryPoint
];

module.exports = {  
    entry: {
        app: app
    },
    output: {
        path: outFolder,
        filename: "[name].js",
        publicPath: 'http://localhost:3000/'
    },
    devtool: "source-map",
    //minimize: true,
    module: {
        loaders: [{
            test: /\.(js|jsx)$/,
            loaders: jsxLoaders,
            exclude: /node_modules/
        },
        {
            test: /\.(css|less)$/,
            loaders: ['style','css','less']
        }]
    },
    plugins: [
      new webpack.HotModuleReplacementPlugin()
    ],
    resolve: {
        extensions: [".webpack.js", ".web.js", ".js", ".jsx"]
    },
    devServer: {
        headers: { "Access-Control-Allow-Origin": "*" }
    }
};
/*
module.exports = {
  mode: 'development',
  entry: { 'main': './js/app.jsx' },
  output: {
    path: path.resolve(__dirname, './Scripts/dist'),
    filename: 'app.js',
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
*/