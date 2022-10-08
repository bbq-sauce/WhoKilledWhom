/*package com.huawei.game.gamekitdemo;

import android.app.Activity;
import android.os.Bundle;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.Message;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.huawei.game.gamekit.GameManager;
import com.huawei.game.gamekitdemo.utils.LogUtil;

import org.json.JSONException;
import org.json.JSONObject;

/**
 * DemoMainActivity
 * This demo just shows how to use all APIs in GameTurbo Engine. It cannot be authenticated by the system because it is not a game app.
 *
 * @since 2019-09-05
 
public class DemoMainActivity extends Activity implements View.OnClickListener {

    private static final String TAG = "DemoMainActivity";

private static final int MSG_REGISTER_WITH_CALLBACK = 0;

private static final int MSG_REGISTER_WITHOUT_CALLBACK = 1;

private static final int MSG_SEND_DATA = 2;

private static final int MSG_GET_PHONE_INFO = 3;

private HandlerThread mWorkThread;

private Handler mHandler;

private GameManager.GameCallBack gameSdkCallBack = new GameManager.GameCallBack() {
        @Override
        public void onPhoneInfoUpdated(String info)
{
    LogUtil.i(TAG, "onPhoneInfoUpdated: " + info);
    Toast.makeText(DemoMainActivity.this, info, Toast.LENGTH_LONG).show();
}
    };

private GameManager mGameManager = GameManager.getGameManager();

@Override
    protected void onCreate(Bundle savedInstanceState)
{
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_demo_main);
    initView();
    initThread();
}

@Override
    protected void onDestroy()
{
    super.onDestroy();
    mWorkThread.quit();
}

@Override
    public void onClick(View v)
{
    Message msg = mHandler.obtainMessage();
    switch (v.getId())
    {
        case R.id.register_sdk_with_callback:
            msg.what = MSG_REGISTER_WITH_CALLBACK;
            mHandler.sendMessage(msg);
            break;
        case R.id.register_sdk_without_callback:
            msg.what = MSG_REGISTER_WITHOUT_CALLBACK;
            mHandler.sendMessage(msg);
            break;
        case R.id.get_phone_info:
            msg.what = MSG_GET_PHONE_INFO;
            mHandler.sendMessage(msg);
            break;
        case R.id.send_data:
            msg.what = MSG_SEND_DATA;
            mHandler.sendMessage(msg);
            break;
        default:
            break;
    }
}

private void initView()
{
    final Button registerWithCb = findViewById(R.id.register_sdk_with_callback);
    registerWithCb.setOnClickListener(this);

    final Button registerWithoutCb = findViewById(R.id.register_sdk_without_callback);
    registerWithoutCb.setOnClickListener(this);

    Button getPhoneInfo = findViewById(R.id.get_phone_info);
    getPhoneInfo.setOnClickListener(this);

    final Button send = findViewById(R.id.send_data);
    send.setOnClickListener(this);
}

private void initThread()
{
    mWorkThread = new HandlerThread("WorkThread");
    mWorkThread.start();
    mHandler = new Handler(mWorkThread.getLooper(), new Handler.Callback() {
            @Override
            public boolean handleMessage(Message message)
    {
        switch (message.what)
        {
            case MSG_REGISTER_WITH_CALLBACK:
                registerKitWithCallback();
                break;
            case MSG_REGISTER_WITHOUT_CALLBACK:
                registerKitWithoutCallback();
                break;
            case MSG_SEND_DATA:
                sendData();
                break;
            case MSG_GET_PHONE_INFO:
                getPhoneInfo();
                break;
            default:
                break;
        }

        return false;
    }
});
    }

    /**
     * Register with callback.
     * If the API returns a failure, the reason is most likely that this demo is not a game app.
     * You can obtain the information of this device by the callback that you passed.
     * The result is same with that call {@link com.huawei.game.gamekit.GameManager#getPhoneInfo()}
     
    private void registerKitWithCallback()
{
    boolean isSuccess = mGameManager.registerGame(getPackageName(), gameSdkCallBack);
    Toast.makeText(this, "register result:" + isSuccess, Toast.LENGTH_LONG).show();
}

/**
 * Register without callback.
 * If the API returns a failure, the reason is most likely that this demo is not a game app.
 
private void registerKitWithoutCallback()
{
    boolean isSuccess = mGameManager.registerGame(getPackageName(), null);
    Toast.makeText(this, "register result:" + isSuccess, Toast.LENGTH_LONG).show();
}

/**
 * You can obtain the information of the device through this method.
 * The result is the same as that callback. {@link com.huawei.game.gamekit.GameManager.GameCallBack#onPhoneInfoUpdated(String)}
 
private void getPhoneInfo()
{
    String phoneInfo = mGameManager.getPhoneInfo();
    Toast.makeText(this, "phoneInfo:" + phoneInfo, Toast.LENGTH_LONG).show();
}

/**
 * Call this method, and send necessary information to the system for scheduling of resources.
 
private void sendData()
{
    String str = getDataString();
    if (str != null)
    {
        mGameManager.updateGameAppInfo(str);
        Toast.makeText(this, "sendData:" + str, Toast.LENGTH_LONG).show();
    }
}

private String getDataString()
{
    JSONObject jsonObject = new JSONObject();
    try
    {
        jsonObject.put("MessageType", 3);
        jsonObject.put("SceneID", 1);
        jsonObject.put("Description", "Game Start");
        jsonObject.put("ImportantLevel", "2");
        jsonObject.put("RecommendFps", 30);
        jsonObject.put("KeyThread", "net|6001");
    }
    catch (JSONException e)
    {
        return null;
    }
    return jsonObject.toString();
}
}*/