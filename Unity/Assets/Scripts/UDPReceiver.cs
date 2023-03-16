using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

public class UDPReceiver : MonoBehaviour
{
    private UdpClient udpClient;
    private IPEndPoint ipEndPoint;

    private async void Start()
    {
        udpClient = new UdpClient(5005);
        ipEndPoint = new IPEndPoint(IPAddress.Any, 0);

        while (true)
        {
            try
            {
                // receive position data via UDP
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                byte[] data = result.Buffer;
                int x = System.BitConverter.ToInt32(data, 0);
                int y = System.BitConverter.ToInt32(data, 4);

                // do something with the position data
                Debug.LogFormat("Received position ({0}, {1})", x, y);
            }
            catch (SocketException e)
            {
                Debug.LogError(e);
            }
        }
    }

    private void OnApplicationQuit()
    {
        udpClient.Close();
    }
}