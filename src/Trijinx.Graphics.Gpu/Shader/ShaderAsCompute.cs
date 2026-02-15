using Trijinx.Graphics.GAL;
using Trijinx.Graphics.Shader;
using Trijinx.Graphics.Shader.Translation;

namespace Trijinx.Graphics.Gpu.Shader
{
    class ShaderAsCompute
    {
        public IProgram HostProgram { get; }
        public ShaderProgramInfo Info { get; }
        public ResourceReservations Reservations { get; }

        public ShaderAsCompute(IProgram hostProgram, ShaderProgramInfo info, ResourceReservations reservations)
        {
            HostProgram = hostProgram;
            Info = info;
            Reservations = reservations;
        }
    }
}
